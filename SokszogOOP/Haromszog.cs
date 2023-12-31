﻿using System;
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
		

		public Haromszog(double a, double b, double c) : base(a)
		{
			this.b = b;
			this.c = c;
			if (!IsSzerkesztheto())
			{
				throw new ArgumentException("A háromszög nem szerkeszthető");
			}
		}

		public Haromszog() : base(VeletlenOldalhossz())
		{
			this.b = VeletlenOldalhossz();
			this.c = VeletlenOldalhossz();
			while (!this.IsSzerkesztheto())
			{
				base.A = VeletlenOldalhossz();
				this.b = VeletlenOldalhossz();
				this.c = VeletlenOldalhossz();
			}
		}

		

		public override double A
		{
			set 
			{
				base.A=value;
				if (!IsSzerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}

		public double B
		{ 
			get => b;
			set 
			{
				b = value;
				if (!IsSzerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			} 
		}
		public double C 
		{ 
			get => c; 
			set 
			{
				c = value;
				if (!IsSzerkesztheto())
				{
					throw new ArgumentException("A háromszög nem szerkeszthető", nameof(value));
				}
			}
		}

		

		private bool IsSzerkesztheto()
		{
			return this.A + this.b > this.c 
				&& this.A + this.c > this.b 
				&& this.b + this.c > this.A;
		}

		public override double GetKerulet()
		{
			return this.A + this.b + this.c;
		}

		public override double GetTerulet()
		{
			double s = (this.A + this.b + this.c) / 2;
			return Math.Sqrt(s * (s - this.A) * (s - this.b) * (s - this.c));
		}

		public override string ToString()
		{
			return $"Háromszög: a: {this.A} - b: {this.b} - c: {this.c} - {base.ToString()}";
		}
	}
}
