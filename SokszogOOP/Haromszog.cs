using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Haromszog : Sokszog
	{
		private double b;
		private double c;
		private static Random rnd = new Random();

		public Haromszog(double a, double b, double c) : base(a)
		{
			this.b = b;
			this.c = c;
		}

		public double B { get => b; set => b = value; }
		public double C { get => c; set => c = value; }

		public Haromszog() : base(VeletlenOldalhossz())
		{
			this.b = VeletlenOldalhossz();
			this.c = VeletlenOldalhossz();
		}

		private static int VeletlenOldalhossz()
		{
			return rnd.Next(5, 15);
		}

		public double GetHaromszogKerulet()
		{
			return this.a + this.b + this.c;
		}

		public double GetHaromszogTerulet()
		{
			double s = (this.a + this.b + this.c) / 2;
			return Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c));
		}
	}
}
