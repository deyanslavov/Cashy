namespace Cashy.App
{
    using System.Windows;

    /// <summary>
    /// Animates a framework element sliding it in from the left on show
    /// and sliding out to the left on hide
    /// </summary>
    public class AnimateSlideInFromRightProperty : AnimateBaseProperty<AnimateSlideInFromRightProperty>
    {
        protected override async void DoAnimationAsync(FrameworkElement element, bool value)
        {
            if (value)
                // Animate in
                await element.SlideAndFadeInFromRightAsync(this.FirstLoad ? 0 : 0.3f);
            else
                // Animate out
                await element.SlideAndFadeOutToRightAsync(this.FirstLoad ? 0 : 0.3f);
        }
    }
}
