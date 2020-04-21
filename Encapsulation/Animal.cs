using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
	class Animal
	{
		private string Name;
		private int Leg;
		protected string Old;

		public string getName()
		{
			return Name;
		}
		public int getLeg()
		{
			return Leg;
		}
		public string getOld()
		{
			return Old;
		}

		public void setName(string name)
		{
			this.Name = name;
		}
		public void setLeg(int leg)
		{
			this.Leg = leg;
		}
		public void setOld(string old)
		{
			this.Old = old;
		}
	}
}
