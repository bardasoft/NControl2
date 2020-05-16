using GradientButtonDemo.Droid;
using GradientButtonDemo.MyControls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace GradientButtonDemo.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Transparent
                Control.BackgroundColor = UIColor.FromWhiteAlpha(1, 1);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}

