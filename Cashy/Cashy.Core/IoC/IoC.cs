namespace Cashy.Core
{
    using Ninject;

    /// <summary>
    /// IoC container for the application
    /// </summary>
    public static class IoC
    {
        #region Public properties
        /// <summary>
        /// The kernel for the IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        #endregion

        /// <summary>
        /// Gets a service from the IoC of the specified type
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        #region Setup
        /// <summary>
        /// Sets up the IoC container, bind all information required and is ready for use
        /// NOTE: Must be called as soon as the application starts up to ensure all services can be found
        /// </summary>
        public static void Setup()
        {
            // Bind all required view models
            BindViewModels();
        }

        /// <summary>
        /// Bind all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            // Bind to a single instance of application view model
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }

        #endregion
    }
}
