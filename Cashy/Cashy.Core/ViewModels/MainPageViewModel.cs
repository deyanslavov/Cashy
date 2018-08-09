namespace Cashy.Core
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Thew View Model for the main screen
    /// </summary>
    public class MainPageViewModel : BaseViewModel
    {
        public string DateTimeNow => DateTime.Now.ToString("", CultureInfo.InvariantCulture);
    }
}
