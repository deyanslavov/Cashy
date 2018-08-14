namespace Cashy.App
{
    using System.Windows;

    /// <summary>
    /// Animates a framework element sliding it in from the left on show
    /// and sliding out to the left on hide
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimationAsync(FrameworkElement element, bool value)
        {
            if (value)
                // Animate in
                await element.SlideAndFadeInFromLeftAsync(this.FirstLoad ? 0 : 0.3f);
            else
                // Animate out
                await element.SlideAndFadeOutToLeftAsync(this.FirstLoad ? 0 : 0.3f);
        }
    }
}
