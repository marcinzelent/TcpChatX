
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label usernameLabel;

	private global::Gtk.Entry usernameEntry;

	private global::Gtk.Label ipLabel;

	private global::Gtk.Entry ipEntry;

	private global::Gtk.Label portLabel;

	private global::Gtk.Entry portEntry;

	private global::Gtk.Button connectButton;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView outputTv;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Entry messageEntry;

	private global::Gtk.Button sendButton;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("TcpChat Client");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(10));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.usernameLabel = new global::Gtk.Label();
		this.usernameLabel.Name = "usernameLabel";
		this.usernameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Username:");
		this.hbox2.Add(this.usernameLabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.usernameLabel]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.usernameEntry = new global::Gtk.Entry();
		this.usernameEntry.CanFocus = true;
		this.usernameEntry.Name = "usernameEntry";
		this.usernameEntry.Text = global::Mono.Unix.Catalog.GetString("Marcin");
		this.usernameEntry.IsEditable = true;
		this.usernameEntry.InvisibleChar = '•';
		this.hbox2.Add(this.usernameEntry);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.usernameEntry]));
		w2.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.ipLabel = new global::Gtk.Label();
		this.ipLabel.Name = "ipLabel";
		this.ipLabel.LabelProp = global::Mono.Unix.Catalog.GetString("IP address:");
		this.hbox2.Add(this.ipLabel);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ipLabel]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.ipEntry = new global::Gtk.Entry();
		this.ipEntry.WidthRequest = 110;
		this.ipEntry.CanFocus = true;
		this.ipEntry.Name = "ipEntry";
		this.ipEntry.Text = global::Mono.Unix.Catalog.GetString("127.0.0.1");
		this.ipEntry.IsEditable = true;
		this.ipEntry.InvisibleChar = '•';
		this.hbox2.Add(this.ipEntry);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ipEntry]));
		w4.Position = 3;
		// Container child hbox2.Gtk.Box+BoxChild
		this.portLabel = new global::Gtk.Label();
		this.portLabel.Name = "portLabel";
		this.portLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Port:");
		this.hbox2.Add(this.portLabel);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.portLabel]));
		w5.Position = 4;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.portEntry = new global::Gtk.Entry();
		this.portEntry.WidthRequest = 50;
		this.portEntry.CanFocus = true;
		this.portEntry.Name = "portEntry";
		this.portEntry.Text = global::Mono.Unix.Catalog.GetString("6789");
		this.portEntry.IsEditable = true;
		this.portEntry.InvisibleChar = '•';
		this.hbox2.Add(this.portEntry);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.portEntry]));
		w6.Position = 5;
		// Container child hbox2.Gtk.Box+BoxChild
		this.connectButton = new global::Gtk.Button();
		this.connectButton.CanFocus = true;
		this.connectButton.Name = "connectButton";
		this.connectButton.UseUnderline = true;
		this.connectButton.Label = global::Mono.Unix.Catalog.GetString("Connect");
		this.hbox2.Add(this.connectButton);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.connectButton]));
		w7.Position = 6;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox2.Add(this.hbox2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.outputTv = new global::Gtk.TextView();
		this.outputTv.CanFocus = true;
		this.outputTv.Name = "outputTv";
		this.outputTv.Editable = false;
		this.GtkScrolledWindow.Add(this.outputTv);
		this.vbox2.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
		w10.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.messageEntry = new global::Gtk.Entry();
		this.messageEntry.CanFocus = true;
		this.messageEntry.Name = "messageEntry";
		this.messageEntry.IsEditable = true;
		this.messageEntry.InvisibleChar = '•';
		this.hbox1.Add(this.messageEntry);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.messageEntry]));
		w11.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.sendButton = new global::Gtk.Button();
		this.sendButton.CanFocus = true;
		this.sendButton.Name = "sendButton";
		this.sendButton.UseUnderline = true;
		this.sendButton.Label = global::Mono.Unix.Catalog.GetString("Send");
		this.hbox1.Add(this.sendButton);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.sendButton]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w13.Position = 2;
		w13.Expand = false;
		w13.Fill = false;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 594;
		this.DefaultHeight = 412;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.connectButton.Clicked += new global::System.EventHandler(this.Connect);
		this.sendButton.Clicked += new global::System.EventHandler(this.SendMessage);
	}
}
