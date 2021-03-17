using Android.Content;
using AndroidX.Core.Content;
using DatingApp.Controles;
using DatingApp.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundCornerEntry), typeof(CustomEntryRenderer))]
namespace DatingApp.Droid.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var nativeEditText = (global::Android.Widget.EditText)Control;
                /* var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                 shape.Paint.Color = Xamarin.Forms.Color.Transparent.ToAndroid();
                 shape.Paint.SetStyle(Paint.Style.Stroke);*/
                nativeEditText.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.EditTextViewShape);
            }
        }
    }
}