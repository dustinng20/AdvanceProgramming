using System;

namespace Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			Rabbit rabbit = new Rabbit();

			rabbit.Eat();
			rabbit.Eat("carrot");
			rabbit.Eat(3, "carrots");
		}
	}
}
