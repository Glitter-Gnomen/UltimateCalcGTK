using System;
using Gtk;

namespace UltiCalcGUI {

public partial class MainWindow: Gtk.Window

{

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

		protected virtual void OnBMIClicked (object sender, EventArgs e)
	{
			//BMIWindow bmiwin = new BMIWindow ();
			//new UltiCalcGUI.BMIWindow ();
			new UltiCalcGUI.theBMIWindow ();
	}

	protected void OnIPNClicked (object sender, EventArgs e)
	{
			new UltiCalcGUI.IPNWindow ();
	}

	protected void OnMConClicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	protected void OnSavingsClicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	protected void OnDebtClicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
		}
	}

}