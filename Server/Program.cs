using System;
using Xwt;

namespace Server
{
	class Program
	{
		[STAThread]
		static void Main()
		{
			Application.Initialize();
			var mainWindow = new MainWindow();
			mainWindow.Show();
			Application.Run();
			mainWindow.Dispose();
		}
	}

}
