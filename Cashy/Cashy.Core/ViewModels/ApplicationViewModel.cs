﻿namespace Cashy.Core
{
    /// <summary>
    /// The application state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;

        public void GoToPage(ApplicationPage page)
        {
            this.CurrentPage = page;
        }
    }
}
