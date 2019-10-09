using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using SlidingMenu;
using SlidingMenu.Droid;
using Android.Graphics.Drawables;
using Android.Graphics;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryAndroid))]
namespace SlidingMenu.Droid
{
	public class CustomEntryAndroid : EntryRenderer
	{
		public CustomEntryAndroid(Context context) : base(context)
		{
			AutoPackage = false;
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				//Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);

				//var nativeEditText = (global::Android.Widget.EditText)Control;

				//var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
				//shape.Paint.SetStyle(Paint.Style.Stroke);
				//nativeEditText.Background = shape;
				//nativeEditText.SetBackgroundColor(global::Android.Graphics.Color.LightGray);

				Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
			}
		}
	}
}
