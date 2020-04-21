using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
	class Rabbit
	{
		public void Eat()
		{
			Console.WriteLine("The rabbit is eating ");
		}
		public void Eat(string fruit)
		{
			Console.WriteLine("The rabbit is eating " + fruit);
		}
		public void Eat(int amount, string fruit)
		{
			Console.WriteLine("The rabbit is eating " + amount + " " +fruit );
		}
	}
}
