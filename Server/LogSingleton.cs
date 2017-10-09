using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Server
{
	public class LogSingleton : INotifyPropertyChanged
	{
		private static LogSingleton _instance;
		public static LogSingleton Instance => _instance ?? (_instance = new LogSingleton());

		private string log;
		public string Log
		{
			get
			{
				return log;
			}
			set
			{
				log = value;
				OnPropertyChanged();
			}
		}

		public List<ClientConnection> ConnectedClients { get; set; }

		private LogSingleton()
		{
			ConnectedClients = new List<ClientConnection>();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
