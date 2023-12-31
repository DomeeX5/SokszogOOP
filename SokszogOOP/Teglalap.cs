﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Teglalap : Sokszog
	{
		private double b;

		public Teglalap(): base(VeletlenOldalhossz())
		{
			this.b = VeletlenOldalhossz();
		}

		public Teglalap(double a, double b) : base(a)
		{
			this.b = b;
		}

		public double B { get => b; set => b = value; }

		public override double GetKerulet()
		{
			return 2 * (this.A + this.b);
		}

		public override double GetTerulet()
		{
			return this.A * this.b;
		}

		public override string ToString()
		{
			return $"Téglalap: a: {this.A} - b: {this.b} - {base.ToString()}";
		}
	}
}
