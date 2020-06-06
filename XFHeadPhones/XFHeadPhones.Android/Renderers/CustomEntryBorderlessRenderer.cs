using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFHeadPhones.Droid.Renderers;
using XFHeadPhones.Renderers;

[assembly: ExportRenderer(typeof(CustomEntryBorderless), typeof(CustomEntryBorderlessRenderer))]
namespace XFHeadPhones.Droid.Renderers
{
    public class CustomEntryBorderlessRenderer : EntryRenderer
    {
        public CustomEntryBorderlessRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.SetBackground(null);
            }
        }
    }
}