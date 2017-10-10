using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
	public class TcpChatClient : INotifyPropertyChanged
	{
		public int Port { get; set; }

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
		public bool Status { get; set; }
		private StreamReader sr;
		private StreamWriter sw;

		public TcpChatClient()
		{
		}

		public async Task Connect(string ipAddress, int port)
		{
			TcpClient clientSocket = new TcpClient(ipAddress, port);
			NetworkStream ns = clientSocket.GetStream();
			sr = new StreamReader(ns);
			sw = new StreamWriter(ns);
			sw.AutoFlush = true;
			Status = true;
			await ReceiveMessageAsync();
		}

		public void SendMessage(string message)
		{
			sw.WriteLine(message);
		}

		private async Task ReceiveMessageAsync()
		{
			while (Status)
			{
				string message = await sr.ReadLineAsync();
				Log += $"{message}\n";
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
