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

		public TimerViewModel()
		{
			_timerText = "Башла";
			_timerColor = Constants.BlueColor;
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
					for (int i = 7; i >= 0; i--)
					{
						await Task.Delay(1000);
						TimerText = i.ToString();
					}

					TimerColor = Constants.RedColor;

					await Task.Delay(3000);
					TimerText = "Башла";
					TimerColor = Constants.BlueColor;

					_activity = false;
				}).Start();
			}
		}
	}
}
