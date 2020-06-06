using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFHeadPhones.iOS.Renderers;
using XFHeadPhones.Renderers;

[assembly: ExportRenderer(typeof(CustomEntryBorderless), typeof(CustomEntryBorderlessRenderer))]
namespace XFHeadPhones.iOS.Renderers
{
    public class CustomEntryBorderlessRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}