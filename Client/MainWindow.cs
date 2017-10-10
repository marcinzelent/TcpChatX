using System;
using Gtk;
using Client;

public partial class MainWindow : Gtk.Window
{
	TcpChatClient tcpChat;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		tcpChat = new TcpChatClient();
		tcpChat.PropertyChanged += (sender, args) =>
			outputTv.Buffer.Text = tcpChat.Log;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected async void Connect(object sender, EventArgs e)
	{
		await tcpChat.Connect(ipEntry.Text, Int32.Parse(portEntry.Text));
		tcpChat.SendMessage($"{usernameEntry.Text} connected.");
	}

	protected void SendMessage(object sender, EventArgs e)
	{
		string message = $"{usernameEntry.Text}: {messageEntry.Text}";
		tcpChat.SendMessage(message);
		messageEntry.Text = "";
	}
}
