using System;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Ipad ipad = new Ipad("Apple", "2019", "Rose Gold", "9.7", 700, "PadOS", "98%", 16);
			ipad.Print();
			ipad.Run();
			Console.ReadLine();

			Galaxytab galaxytab = new Galaxytab("Samsung", "Tab S", "White", "10.5", 950, "Android 8 Onion", "8GB", 64);
			galaxytab.Print();
			galaxytab.Run();
			Console.WriteLine();

			Zenpad zenpad = new Zenpad("Asus", "Z370", "Black", "7", 350, "ZenOs", 16);
			zenpad.Print();
			zenpad.Run();
			Console.WriteLine();
		}
	}
}
