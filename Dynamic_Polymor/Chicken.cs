using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Polymor
{
	class Chicken : Animal
	{
		public decimal Price;
		public Chicken() : base()
		{
			Price = 0;
		}
		public Chicken(string name, int leg, decimal price) : base(name, leg)
		{
			Price = price;
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("This chicken has:" + Price + " $");
		}
	}
}
