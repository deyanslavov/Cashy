namespace Cashy.Core
{
    using System;
    using System.Globalization;

    public class MainPageDesignModel : MainPageViewModel
    {
        public static MainPageDesignModel Instance => new MainPageDesignModel();

        public MainPageDesignModel()
        {
            this.Balance = "100.21";
            this.DateTimeNow = DateTime.Now.ToString("ddd d MMM yyyy", CultureInfo.InvariantCulture);
            this.Currency = "$";
        }
    }
}
