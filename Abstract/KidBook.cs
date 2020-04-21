using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
	class KidBook : Book
	{
		public string bookName;
		public KidBook(string bookname, string booklang, string author, int pubyear, double price)
			: base(booklang, author, pubyear, price)
		{
			bookName = bookname;
		}

		public override string Print()
		{
			return bookName + base.Print();
		}

		public override void BookType()
		{
			Console.WriteLine("This book is for Kids");
		}
	}
}
