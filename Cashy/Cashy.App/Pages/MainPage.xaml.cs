namespace Cashy.App
{
    using Cashy.Core;
    using System;
    using System.Collections.Generic;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : BasePage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
            this.Records.DataContext = new List<Record>()
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
    }
}
