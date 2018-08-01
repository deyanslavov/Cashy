namespace Cashy.App
{
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// Thew View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flas indicating if login is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            // Create commands
            this.LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the user's password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await this.RunCommand(() => this.LoginIsRunning, async () => 
            {
                await Task.Delay(5000);

                string email = this.Email;
                string password = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
        }
    }
}
