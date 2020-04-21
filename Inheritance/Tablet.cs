using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

	public class Tablet
	{
		public string brandName;
		public string modelName;
		public string Color;
		public string screenSize;
		public double Price;

		public Tablet()
		{
		}

		public Tablet(string brandname, string modelname, string color, string screensize, double price)
		{
			brandName = brandname; 
			modelName = modelname;
			Color = color;
			screenSize = screensize;
			Price = price;
		}
		
		public virtual void Print()
		{
			Console.WriteLine("Brand Name: {0}", brandName);
			Console.WriteLine("Model Name: {0}", modelName);
			Console.WriteLine("Color: {0}", Color);
			Console.WriteLine("Screen Size: {0}", screenSize);
			Console.WriteLine("Price: {0}", Price + "$");
		}
		public virtual void Run()
		{
			Console.WriteLine("This model is Genuine ");
		}
	}
}
