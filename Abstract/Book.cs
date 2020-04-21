using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
	public abstract class Book
	{
			public string bookLang; //Language of Books
			public string Author;
			public int pubYear;
			public double Price;

			public Book(string booklang, string author, int pubyear, double price)
			{
				bookLang = booklang;
				Author = author;
				pubYear = pubyear;
				Price = price;
			}

			public virtual string Print()
			{
				return "/" + bookLang + " /" + Author + " /" + pubYear + " /" + Price + "$";
			}

			public abstract void BookType();

		
	}
}
