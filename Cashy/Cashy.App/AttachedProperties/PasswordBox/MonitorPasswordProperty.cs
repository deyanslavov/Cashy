﻿namespace Cashy.App
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// The MonitorPassword attached property for a PasswordBox
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the caller
            PasswordBox passwordBox = sender as PasswordBox;

            // Make sure it is a password box
            if (passwordBox == null)
                return;

            // Remove any previous events
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            // If the caller set MonitorPassword to true
            if ((bool)e.NewValue)
            {
                // Set value
                HasTextProperty.SetValue(passwordBox); ;

                // Start listening out for password changes
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        /// <summary>
        /// Fired when the passwordbox value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }
}