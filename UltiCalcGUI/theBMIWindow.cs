using System;
using Gtk;

namespace UltiCalcGUI
{
	public partial class theBMIWindow : Gtk.Window
	{
		public theBMIWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			double a, b, c;
			a = Convert.ToDouble (num1.Text);
			b = Convert.ToDouble (num2.Text);

			a = a * 0.01;

			c = b / (a * a);
			c = Math.Round (c, 2);

			if (c <= 18.5) {
				lab1.Text = "...Underweight...";
			}
			if (c > 18.5 && c < 25) {
				lab1.Text = "...Normalweight...";
			}
			if (c >= 25 && c < 30) {
				lab1.Text = "...Overweight...";
			}
			if (c >= 30 && c < 40) {
				lab1.Text = "...Obese...";
			}
			if (c >= 40) {
				lab1.Text = "...Severely obese...";
			}

			num3.Text = c.ToString ();


		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			new UltiCalcGUI.theBMIWindow ();
			//num1.Text = num2.Text = num3.Text = "";
		}
	}
}

