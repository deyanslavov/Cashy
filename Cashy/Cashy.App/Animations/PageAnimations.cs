namespace Cashy.App.Animations
{
    using System.Windows;
    using System.Threading.Tasks;
    using System.Windows.Controls;
    using System.Windows.Media.Animation;

    /// <summary>
    /// Helpers to animate pages in specific ways
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// Slides a page in from right
        /// </summary>
        /// <param name="page">The Page to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            // Create the storyboard
            Storyboard storyboard = new Storyboard();

            // Add slide from right animation
            storyboard.AddSlideFromRight(seconds, page.WindowWidth);

            // Add fade in animation
            storyboard.AddFadeIn(seconds);

            // Start animating
            storyboard.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides a page out to left
        /// </summary>
        /// <param name="page">The Page to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            // Create the storyboard
            Storyboard sb = new Storyboard();

            // Add slide from right animation
            sb.AddSlideToLeft(seconds, page.WindowWidth);

            // Add fade in animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }
    }
}
