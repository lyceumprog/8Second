using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SecondTimer.Droid
{
	[Activity(Label = "8SecondTimer.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			GetMetrics();
			LoadApplication(new App());
		}

		void GetMetrics()
		{
			var bounds = Resources.DisplayMetrics;

			App.Width = bounds.WidthPixels / bounds.Density;
			App.Height = bounds.HeightPixels / bounds.Density;
		}
	}
}
