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

		public Teglalap(double a, double b) : base(a)
		{
			this.b = b;
		}

		public double B { get => b; set => b = value; }

		public double GetKerulet()
		{
			return 2 * (this.a + this.b);
		}

		public double GetTerulet()
		{
			return this.a * this.b;
		}

		public override string ToString()
		{
			return $"a: {this.a} - b: {this.b} - K: {this.GetKerulet()} - T: {this.GetTerulet()}";
		}
	}
}
