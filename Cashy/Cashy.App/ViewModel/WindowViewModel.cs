namespace Cashy.App
{
    using System;
    using System.Windows;
    using System.Windows.Input;
    using System.Runtime.InteropServices;
    using Cashy.Core;

    /// <summary>
    /// Thew View Model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// The margin around the window to allow a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        private int mWindowRadius = 10;

        #endregion

        #region Public Properties

        /// <summary>
        /// The smallest width the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 700;

        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 700;

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        /// 
        public int ResizeBorder { get; set; } = 3;

        /// <summary>
        /// The size of the resize border around the window, taking into account the outer margin
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(this.ResizeBorder);

        /// <summary>
        /// The padding of the inner content of the main window
        /// </summary>
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);

        /// <summary>
        /// The margin around the window to allow a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return this.mWindow.WindowState == WindowState.Maximized ? 0 : this.mOuterMarginSize;
            }
            set
            {
                this.mOuterMarginSize = value;
            }
        }

        /// <summary>
        /// The margin around the window to allow a drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness => new Thickness(this.OuterMarginSize);

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return this.mWindow.WindowState == WindowState.Maximized ? 0 : this.mWindowRadius;
            }
            set
            {
                this.mWindowRadius = value;
            }
        }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(this.mWindowRadius);


        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 35;

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public GridLength TitleHeightGridLength => new GridLength(this.TitleHeight + this.ResizeBorder);

        #endregion

        #region Commands

        /// <summary>
        /// The command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to show the system menu of the window
        /// </summary>
        public ICommand MenuCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            this.mWindow = window;

            // Listen out for the window resizing
            this.mWindow.StateChanged += (sender, e) =>
            {
                // Fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowCornerRadius));
                OnPropertyChanged(nameof(WindowRadius));
            };

            // Create commands
            this.MinimizeCommand = new RelayCommand(() => this.mWindow.WindowState = WindowState.Minimized);
            this.MaximizeCommand = new RelayCommand(() => this.mWindow.WindowState ^= WindowState.Maximized);
            this.CloseCommand = new RelayCommand(() => this.mWindow.Close());
            this.MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(this.mWindow, GetMousePosition()));

            // Fix window resize issue
            WindowResizer resizer = new WindowResizer(this.mWindow);
        }

        #endregion

        #region Private Helpers

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        /// <summary>
        /// Get the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            // Position of the mouse relative to the window
            Point position = Mouse.GetPosition(this.mWindow);

            // Add the window position so its a "ToScreen"
            return new Point(position.X + this.mWindow.Left, position.Y + this.mWindow.Top);
        }

        #endregion
    }
}
