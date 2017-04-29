using System;
using Xamarin.Forms;

namespace SecondTimer
{
	public class TimerView : ContentPage
	{
		TimerViewModel viewModel;
		private bool firstLaunch = true;

		public TimerView()
		{
			BindingContext = viewModel = new TimerViewModel();
			InitializeComponents();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (firstLaunch)
			{
				firstLaunch = false;
				DisplayAlert("Исәнмесез, дуслар!", Constants.WelcomeText, "Башларга");
			}
		}

		void InitializeComponents()
		{
			var timerText = new Label
			{
				TextColor = Constants.TextColor,
				FontSize = 50,
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalTextAlignment = TextAlignment.Center,
				FontFamily = Device.OnPlatform("", "TT_Madera.otf#Regular", null)
			};
			timerText.SetBinding(Label.TextProperty, "TimerText");

			var size = App.Width * .8;

			var frame = new Frame()
			{
				WidthRequest = size,
				HeightRequest = size,
				Content = timerText,
				CornerRadius = (float)(size / 2),
				Padding = new Thickness(0, 0)
			};
			frame.SetBinding(Frame.BackgroundColorProperty, "TimerColor");

			var timerStartGesture = new TapGestureRecognizer();
			timerStartGesture.Tapped += viewModel.StartTimer;

			frame.GestureRecognizers.Add(timerStartGesture);

			var mainLayout = new AbsoluteLayout();

			mainLayout.Children.Add(frame, new Rectangle(.5, .5, -1, -1), AbsoluteLayoutFlags.PositionProportional);

			Content = mainLayout;
		}
	}
}
