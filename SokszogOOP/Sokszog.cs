using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal abstract class Sokszog
	{
		protected double a;

		public Sokszog(double a)
		{
			this.a = a;
		}

		public double A { get => a; set => a = value; }

		public abstract double GetKerulet();
		public abstract double GetTerulet();

		public override string ToString()
		{
			return $"K: {this.GetKerulet()} - T: {this.GetTerulet()}";
		}
	}
}
