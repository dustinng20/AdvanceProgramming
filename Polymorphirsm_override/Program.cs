using System;

namespace Polymorphirsm_override
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal();
			Bear bear = new Bear();
			animal.Eat();
			bear.Eat();
		}
	}
}
