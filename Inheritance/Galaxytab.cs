using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	class Galaxytab : Tablet
	{
		public string Os;
		public string ROM;
		public int Memory;

		
		public Galaxytab(string brandname, string modelname, string color,
			string screensize, double price, string os, string rom, int memory)
			: base(brandname, modelname, color, screensize, price)
		{
			Os = os;
			ROM = rom;
			Memory = memory;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("The operating system is:" + Os);
			Console.WriteLine("The rom is:" + ROM);
			Console.WriteLine("The memory is:" + Memory + "GB");
		}
	}
}
