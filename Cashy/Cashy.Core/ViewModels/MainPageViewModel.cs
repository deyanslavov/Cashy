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
        public string DateTimeNow => DateTime.Now.ToString("ddd d MMM yyyy", CultureInfo.InvariantCulture);

        public string Balance { get; set; } = "$100.21";

        public List<Record> items = new List<Record>()
            {
                new Record{Category = "Health", Amount = 123.12M},
                new Record{Category = "Health", Amount = 123.12M},
                new Record{Category = "Health", Amount = 123.12M},
                new Record{Category = "Health", Amount = 123.12M},
                new Record{Category = "Health", Amount = 123.12M},
                new Record{Category = "Health", Amount = 123.12M},
                new Record{Category = "Health", Amount = 123.12M},
            };
    }

    public class Record
    {
        public string Category { get; set; }

        public decimal Amount { get; set; }
    }
}
