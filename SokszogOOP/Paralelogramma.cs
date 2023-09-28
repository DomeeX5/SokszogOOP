using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Paralelogramma : Teglalap
	{
		private double alpha;
		public Paralelogramma(double a, double b, double alpha) : base(a, b)
		{
			this.alpha = alpha;
		}

		public Paralelogramma() : base(VeletlenOldalhossz(), VeletlenOldalhossz())
		{
			this.alpha = VeletlenSzog();
		}

		public double Alpha { get => alpha; set => alpha = value; }

		public override double GetKerulet()
		{
			return base.GetKerulet();
		}

		public override double GetTerulet()
		{
			return base.GetTerulet() * Math.Sin(FokToRadian(this.alpha));
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
