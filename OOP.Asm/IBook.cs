using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Asm
{
	interface IBaby
	{
		public void Eat();
		public void Cry();
	}
 
	interface ISex
	{
		void Play();
		bool HasBoy { get; set; }
	}
	
 class Baby
	{
		protected int Height { get; set; }
	}
	
	class Boy : Baby, IBaby, ISex
	{
		private bool hasBoy;
		public void Eat()
		{
			this.Height = 110;
			Console.WriteLine($"Boy is eating..., Height = {this.Height}");
		}
		public void Cry()
		{
			Console.WriteLine("Boy is crying...");
		}

		public void Play()
		{
			Console.WriteLine("Boy is playing");
		}
		public bool HasBoy 
		{ 
		get
			{
				Console.WriteLine("Calling getter...");
				return this.hasBoy;
			}
		set
			{
				Console.WriteLine("Calling Setter...");
				this.hasBoy = value;
			}
		}
	} 
 
	//class Programs
	{
		//static void Main(string[] args)
		{
			var boy = new Boy();
			boy.Eat();
			boy.Cry();
			boy.Play();
			boy.HasBoy = true;
		}
	}
}
