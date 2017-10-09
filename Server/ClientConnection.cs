using System;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
	public class ClientConnection
	{
		public StreamReader StreamReader { get; set; }
		public StreamWriter StreamWriter { get; set; }

		public ClientConnection(TcpListener listener)
		{
			TcpClient connectionSocket = listener.AcceptTcpClient();
			NetworkStream ns = connectionSocket.GetStream();
			StreamReader = new StreamReader(ns);
			StreamWriter = new StreamWriter(ns);
			StreamWriter.AutoFlush = true;
			Task.Run(() => EchoService(StreamReader, StreamWriter));
		}

		private async Task EchoService(StreamReader sr, StreamWriter sw)
		{
			while (true)
			{
				string message = await sr.ReadLineAsync();
				LogSingleton.Instance.Log += $"{message}\n";
				foreach (ClientConnection client in LogSingleton.Instance.ConnectedClients) client.StreamWriter.WriteLine(message);
				message = "";
			}
		}
	}
}
