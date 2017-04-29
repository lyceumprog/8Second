using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SecondTimer
{
	public class TimerViewModel : BaseViewModel
	{
		private Color _timerColor;
		private string _timerText;
		private bool _activity;

		public Color TimerColor
		{
			get { return _timerColor; }
			set { _timerColor = value; OnPropertyChanged(); }
		}
		public string TimerText
		{
			get { return _timerText; }
			set { _timerText = value; OnPropertyChanged(); }
		}

		IAudio audioService;

		public TimerViewModel()
		{
			_timerText = "Башла";
			_timerColor = Constants.BlueColor;

			audioService = DependencyService.Get<IAudio>();
		}

		public void StartTimer(object sender, EventArgs e)
		{
			if (!_activity)
			{
				_activity = true;
				new Task(async () =>
				{
					TimerText = "8";
					TimerColor = Constants.GreenColor;
					for (int i = 8; i > 0; i--)
					{
						audioService.Tick();
						TimerText = i.ToString();
						await Task.Delay(1000);
					}

					TimerText = "0";
					TimerColor = Constants.RedColor;
					audioService.Dong();

					await Task.Delay(3000);
					TimerText = "Башла";
					TimerColor = Constants.BlueColor;

					_activity = false;
				}).Start();
			}
		}
	}
}
