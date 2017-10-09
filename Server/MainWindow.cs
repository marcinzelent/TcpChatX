using System;
using Xwt;
using Xwt.Formats;

namespace Server
{
	public class MainWindow : Window
	{
		TcpChatServer tcpChatServer;

		public MainWindow()
		{
			Title = "TCP Chat X Server";
			Width = 600;
			Height = 400;

			VBox mainVBox;
			HBox connectionHBox, messageHBox;
			TextEntry ipTextEntry = new TextEntry
			{
				PlaceholderText = "IP Address",
				Text = "127.0.0.1",
			};
			TextEntry portTextEntry = new TextEntry
			{
				WidthRequest = 100,
				PlaceholderText = "Port",
				Text = "6789"
			};
			Button startButton = new Button
			{
				Label = "Start"
			};
			startButton.Clicked += (object sender, EventArgs e) =>
			{
				tcpChatServer = new TcpChatServer();
				tcpChatServer.Start(ipTextEntry.Text, int.Parse(portTextEntry.Text));
			};
			RichTextView outputTextView = new RichTextView
			{
				ExpandHorizontal = true,
				ExpandVertical = true,
				MinHeight = 200
			};
			LogSingleton.Instance.PropertyChanged += (sender, args) =>
				outputTextView.LoadText(LogSingleton.Instance.Log, TextFormat.Plain);
			
			TextEntry messageTextEntry = new TextEntry()
			{
				PlaceholderText = "Message"
			};
			Button sendButton = new Button 
			{ 
				Label = "Send"
			};
			sendButton.Clicked += (object sender, EventArgs e) =>
			{
				tcpChatServer.SendMessage($"Server: {messageTextEntry.Text}");
				messageTextEntry.Text = "";
			};

			Content = mainVBox = new VBox();

			mainVBox.PackStart(connectionHBox = new HBox());
			connectionHBox.PackStart(ipTextEntry , true);
			connectionHBox.PackStart(portTextEntry);
			connectionHBox.PackStart(startButton);

			mainVBox.PackStart(outputTextView, true, true);

			mainVBox.PackStart(messageHBox = new HBox());
			messageHBox.PackStart(messageTextEntry, true, true);
			messageHBox.PackStart(sendButton);
		}
	}
}
