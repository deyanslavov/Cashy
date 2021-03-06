﻿namespace Cashy.App
{
    using System.Windows;
    using System.Windows.Navigation;
    using System.Windows.Controls;

    /// <summary>
    /// The NoFrameHistory attached property for creating a <see cref="Frame"/> that never shows navigation
    /// and keeps the navigation history empty
    /// </summary>
    public class NoFrameHistoryProperty : BaseAttachedProperty<NoFrameHistoryProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the frame
            Frame frame = (sender as Frame);

            // Hide navigation bar
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            // Clear history on navigate
            frame.Navigated += (ss, ee) => ((Frame)ss).NavigationService.RemoveBackEntry();
        }
    }
}
