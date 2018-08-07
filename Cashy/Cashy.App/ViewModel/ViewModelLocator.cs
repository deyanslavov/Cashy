namespace Cashy.App
{
    using Cashy.Core;

    /// <summary>
    /// Locates view models from the IoC for use in binding in XAML Files
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// A singleton instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// The application view model
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoC.Get<ApplicationViewModel>();
    }
}
