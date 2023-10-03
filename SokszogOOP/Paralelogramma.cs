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

		public double Alpha
		{
			get => alpha;
			set
			{
				if (value >= 180)
				{
					throw new ArgumentException("Az oldalak által közbezárt szög nem lehet 180°-nál nagyobb", nameof(value));
					alpha = value;
				}
			}
		}

		public Paralelogramma(double a, double b, double alpha) : base(a, b)
		{
			if (alpha >= 180)
			{
				throw new ArgumentException("Az oldalak által közbezárt szög nem lehet 180°-nál nagyobb", nameof(alpha));
			}
			this.alpha = alpha;
		}

		public Paralelogramma() : base(VeletlenOldalhossz(), VeletlenOldalhossz())
		{
			this.alpha = VeletlenSzog();
		}

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
			return $"Paralelogramma: alfa: {this.alpha}° - {base.ToString()}";
		}
	}
}
