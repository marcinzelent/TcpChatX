using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Server
{
	public class TcpChatServer
	{
		TcpListener serverSocket;

		public void Start(string ipAddress, int port)
		{
			try
			{
				serverSocket = new TcpListener(IPAddress.Parse(ipAddress), port);
				serverSocket.Start();
				LogSingleton.Instance.Log += "Server started.\n";
				Task.Run(() => Listen(serverSocket));
				LogSingleton.Instance.Log += "Waiting for connections...\n";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void Listen(TcpListener listener)
		{
			while (true)
			{
				ClientConnection cc = new ClientConnection(listener);
				LogSingleton.Instance.ConnectedClients.Add(cc);
			}
		}

		public void Stop()
		{
			serverSocket.Stop();
			LogSingleton.Instance.Log += "Server stopped\n";
		}

		public void SendMessage(string message)
		{
			foreach (ClientConnection client in LogSingleton.Instance.ConnectedClients) client.StreamWriter.WriteLine(message);
		}
	}
}
