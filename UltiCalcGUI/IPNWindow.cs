using System;
using Gtk;

namespace UltiCalcGUI
{
	public partial class IPNWindow : Gtk.Window
	{
		public IPNWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		public static double myVariable1;
		public static double myVariable2;
		public static string myVariable3;	

		IPN.Calcs (var1);




		//User picks desired mathematical operation
		Console.WriteLine ("Select calculation");
		var3 = (Console.ReadLine ());


		//Switch case for the different calculation operations
		switch (var3) {

		//Addition
		case "+": 
			add.adding (calcVar1, var2);
			break;

			//Subtraction
		case "-":
			sub.subbing (calcVar1, var2);
			break;

			//Multiplication
		case "*":
			mul.multiplying (calcVar1, var2);
			break;

			//Division
		case "/":
			div.dividing (calcVar1, var2);
			break;

			//Modulus
		case "%":
			mod.modulo(calcVar1, var2);
			break;
		}
	}





		protected void OnButton1Clicked (object sender, EventArgs e)
		{

			double var1 = 1;
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			double var2 = 2;
		}

		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			double var3 = 3;
		}

		protected void OnButton4Clicked (object sender, EventArgs e)
		{
			double var4 = 4;		
		}

		protected void OnButton5Clicked (object sender, EventArgs e)
		{
			double var5 = 5;
		}

		protected void OnButton6Clicked (object sender, EventArgs e)
		{
			double var6 = 6;
		}

		protected void OnButton7Clicked (object sender, EventArgs e)
		{
			double var7 = 7;
		}

		protected void OnButton8Clicked (object sender, EventArgs e)
		{
			double var8 = 8;
		}

		protected void OnButton9Clicked (object sender, EventArgs e)
		{
			double var9 = 9;
		}

		protected void OnButtonClicked (object sender, EventArgs e)
		{
			double var0 = 0;
		}

		protected void OnButtonPlusClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonMinusClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonMultiplyClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonDivideClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonModulusClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonEnterClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonCommaClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

