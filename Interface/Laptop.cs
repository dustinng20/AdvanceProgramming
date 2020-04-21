using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
	public class Laptop : ILaptop
	{
		private int ID;
		private string brandName;
		private string modelName;
		private double Price;

		public Laptop(int id, string brandname, string modelname, double price)
		{
			ID = id;
			brandName = brandname;
			modelName = modelname;
			Price = price;
		}
		public double GetPrice()
		{
			return Price;
		}
		public void Model()
		{
			Console.WriteLine("ID: {0}", ID);
			Console.WriteLine("Brand Name: {0}", brandName);
			Console.WriteLine("Model Name: {0}", modelName);
			Console.WriteLine("Price: {0}", Price + "$");
		}
	}
}
