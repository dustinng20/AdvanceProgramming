using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Asm
{
	//Abstract class
	abstract class Book 
	{
		//Abstract method
		public abstract void bookChapter();
		//Normal method
		public void pageNum()
		{
			Console.WriteLine("Page 15");
		}
	}

	class Chapter_1 : Book
	{
		public override void bookChapter()
		{
			Console.WriteLine("Chapter 1: The shepherd of Santiago.");
		}
	}
}
