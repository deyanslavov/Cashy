namespace Cashy.Core
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// Thew View Model for the main screen
    /// </summary>
    public class MainPageViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The current date time to be displayed at the top of the page
        /// </summary>
        public string DateTimeNow { get; set; }

        /// <summary>
        /// The current balance of the user
        /// </summary>
        public string BalanceAmount { get; set; }

        /// <summary>
        /// The currency the user selected
        /// </summary>
        public string Currency { get; set; }
        
        #endregion

        #region Commands

        /// <summary>
        /// The command to show the left side menu
        /// </summary>
        public ICommand ShowLeftSideMenuCommand { get; set; }

        /// <summary>
        /// The command to show the right side menu
        /// </summary>
        public ICommand ShowRightSideMenuCommand { get; set; }

        #endregion

        #region Construtor

        public MainPageViewModel()
        {
            this.ShowLeftSideMenuCommand = new RelayCommand(async () => await ShowLeftSideMenu());
            this.ShowRightSideMenuCommand = new RelayCommand(async () => await ShowRightSideMenu());
        }

        #endregion

        #region Command Methods

        private Task ShowRightSideMenu()
        {
            throw new NotFiniteNumberException();
        }

        private Task ShowLeftSideMenu()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
