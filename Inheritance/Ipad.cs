using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	class Ipad : Tablet
	{
		public string Os;
		public string Quality;
		public int Memory;

		
		public Ipad(string brandname, string modelname, string color, string screensize,
			double price, string os, string quality, int memory)
			: base(brandname, modelname, color, screensize, price)
		{
			Os = os;
			Quality = quality;
			Memory = memory;
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine("The operating system is: {0}", Os);
			Console.WriteLine("The quality is: {0}", Quality);
			Console.WriteLine("The memory is: {0}", Memory + "GB");
		}
	}
}
