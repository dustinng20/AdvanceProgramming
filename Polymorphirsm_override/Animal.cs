using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphirsm_override
{
	class Animal
	{
		public string Name;
		public int Leg;

		public Animal(string name, int leg)
		{
			Name = name;
			Leg = leg;
		}
		public virtual void Print()
		{
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("Leg: " + Leg);
		}
		public void Eat()
		{
			Console.WriteLine("This animal is Eating...");
		}
	}

	internal class Bear : Animal
	{
	}
}
