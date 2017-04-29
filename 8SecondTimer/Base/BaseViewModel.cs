using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SecondTimer
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public void OnPropertyChanged([CallerMemberName]string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
