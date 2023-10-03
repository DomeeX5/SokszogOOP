using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal abstract class Sokszog
	{
		private double a;
		private static Random rnd = new Random();

		public Sokszog(double a)
		{
			this.a = a;
		}

		public virtual double A { get => a; set => a = value; }

		public abstract double GetKerulet();
		public abstract double GetTerulet();

		public static int VeletlenOldalhossz()
		{
			return rnd.Next(1, 100);
		}

		public static int VeletlenSzog()
		{
			return rnd.Next(1, 180);
		}

		public static double FokToRadian(double fok)
		{
			return fok * Math.PI / 180;
		}

		public override string ToString()
		{
			return $"K: {this.GetKerulet()} - T: {this.GetTerulet()}";
		}
	}
}
