namespace Cashy.App
{
    using System;
    using System.Windows;
    using System.Globalization;
    using System.Windows.Media;

    /// <summary>
    /// A converter that takes in the user's current balance and returns a color for the foreground
    /// </summary>
    public class BalanceToColorConverter : BaseValueConverter<BalanceToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Parse the balance as a string to a decimal number
            value = decimal.Parse(value.ToString());

            if ((decimal)value == 0)
                return new SolidColorBrush(Colors.Gray);
            else if ((decimal)value > 0)
                return new SolidColorBrush(Colors.ForestGreen);
            else
                return new SolidColorBrush(Colors.Red);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
