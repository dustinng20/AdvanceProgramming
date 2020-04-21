using System;

namespace Encapsulation
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal();

			animal.setName("Min");
			animal.setLeg(4);
			animal.setOld("3");

			Console.WriteLine("Name:" + " " + animal.getName());
			Console.WriteLine("Leg:" + animal.getLeg() + " " + "legs");
			Console.WriteLine("Old:" + " " + animal.getOld() + " "+ "months");
		}
	}
}
