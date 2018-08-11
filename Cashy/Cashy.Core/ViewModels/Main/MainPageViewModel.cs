namespace Cashy.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Thew View Model for the main screen
    /// </summary>
    public class MainPageViewModel : BaseViewModel
    {
        /// <summary>
        /// The current date time to be displayed at the top of the page
        /// </summary>
        public string DateTimeNow { get; set; }

        /// <summary>
        /// The current balance of the user
        /// </summary>
        public string Balance { get; set; }

        /// <summary>
        /// The currency the user selected
        /// </summary>
        public string Currency { get; set; }
    }
}
