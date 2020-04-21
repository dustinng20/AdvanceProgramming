using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Asm
{
	public class detectiveBook : bookStore
	{
		public string bookName;
		public detectiveBook(string bookname, string booklang, string author, int pubyear, double price)
			: base(booklang, author, pubyear, price)
		{
			bookName = bookname;
		}
		public override void BookType()
		{
			Console.WriteLine("This book is for Adults");
		}
		public override string Print()
		{
			return base.Print() + bookName;
		}
	}
}
