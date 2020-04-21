using System;

namespace Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			Laptop laptop = new Laptop(1, "DELL", "Vostro", 350);
			laptop.Model();
			Console.ReadLine();
		}
	}
}
