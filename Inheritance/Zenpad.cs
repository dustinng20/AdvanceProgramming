using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	class Zenpad : Tablet
	{
		public string Os;
		public int Memory;

		public Zenpad() : base()
		{
			Os = "None";
			Memory = 0;
		}
		public Zenpad(string brandname, string modelname, string color, 
			string screensize, double price, string os, int memory)
			: base(brandname, modelname, color, screensize, price)
		{
			Os = os;
			Memory = memory;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("The operating system is:" + Os);
			Console.WriteLine("The memory is:" + Memory + "GB");
		}
	}

}
