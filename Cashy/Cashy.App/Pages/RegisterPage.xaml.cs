namespace Cashy.App
{
    using Cashy.Core;

    using System.Security;

    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<LoginViewModel>, IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The secure password for this login page
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //this.AnimateOut();
        }
    }
}
