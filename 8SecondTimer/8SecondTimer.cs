using System;

using Xamarin.Forms;

namespace SecondTimer
{
	public class App : Application
	{
		static public double Width;
		static public double Height;

		public App()
		{
			// The root page of your application
			MainPage = new NavigationPage(new TimerView());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
