using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Teglalap : Sokszog
	{
		private double b;

		public Teglalap(double a,double b) : base(a)
		{
			this.b = b;
		}
	}
}
