using System;
using Gtk;

namespace UltiCalcGUI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			//BMIWindow bmiwin = new BMIWindow ();


			win.Show ();
			Application.Run ();


		}
	}
}
