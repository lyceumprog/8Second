using System;
using Android.Media;
using SecondTimer.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioImpl))]
namespace SecondTimer.Droid
{
	public class AudioImpl : IAudio
	{
		private MediaPlayer _tick;
		private MediaPlayer _dong;

		public AudioImpl()
		{
			_tick = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.tick);
			_dong = MediaPlayer.Create(global::Android.App.Application.Context, Resource.Raw.timer_or_desk_bell);
		}

		public void Tick()
		{
			_tick.Start();
		}

		public void Dong()
		{
			_dong.Start();
		}
	}
}
