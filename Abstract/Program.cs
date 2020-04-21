using System;

namespace Abstract
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("This are my Cart:");
			Console.ReadKey();

			KidBook mynovel = new KidBook("Conan", "Japanese", "Yutaka Tani", 2005, 20);
			Console.WriteLine(mynovel.Print());
			Console.ReadKey();

			mynovel.BookType();
			Console.ReadKey();



			AdultBook mybook = new AdultBook("The Alchemist", "English", "Paulo Coelho", 1988, 50);
			Console.WriteLine(mybook.Print());
			Console.ReadKey();

			mybook.BookType();
			Console.ReadKey();
		}
	}
}
