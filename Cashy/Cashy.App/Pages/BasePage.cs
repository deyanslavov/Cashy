namespace Cashy.App
{
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;

    using Animations;

    /// <summary>
    /// A base page for all pages to gain base functionality
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {
        #region Private Members

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The animation to play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation to play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => this.mViewModel;
            set
            {
                // If nothing has changed - return
                if (this.mViewModel == value)
                    return;

                // Update the value
                this.mViewModel = value;

                // Set the data context for this page
                this.DataContext = this.mViewModel;
            }
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            // If we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
            {
                this.Visibility = Visibility.Collapsed;
            }

            // Listen out for the page loading
            this.Loaded += BasePage_Loaded;

            // Create a default view model
            this.ViewModel = new VM();
        }

        #endregion

        #region Animation Load/Unload

        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            await AnimateIn();
        }

        /// <summary>
        /// Animates in this page
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            // Make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None)
            {
                return;
            }

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // Start the animation
                    await this.SlideAndFadeInFromRight(this.SlideSeconds);

                    break;
            }
        }

        /// <summary>
        /// Animates out this page
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            // Make sure we have something to do
            if (this.PageUnloadAnimation == PageAnimation.None)
            {
                return;
            }

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);

                    break;

            }
        }

        #endregion
    }
}
