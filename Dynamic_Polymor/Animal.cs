using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Polymor
{
	class Animal
	{
		public string Name;
		public int Leg;

		public Animal()
		{
		}

		public Animal(string name, int leg)
		{
			Name = name;
			Leg = leg;
		}
		public void Print()
		{
			Console.WriteLine("Name:" + " " + Name);
			Console.WriteLine("Leg:" +" " + Leg);
		}
		public virtual void Print()
		{
			Console.WriteLine("Name: " + Name);
			Console.WriteLine("leg :" + Leg);
		}
	}
}
