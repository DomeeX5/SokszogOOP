﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Haromszog haromszog = new Haromszog();
			Haromszog haromszog2 = new Haromszog(3, 4, 5);
			Teglalap teglalap = new Teglalap(3, 5);
			Teglalap teglalap2 = new Teglalap(4, 2);

			Console.WriteLine(haromszog);
			Console.WriteLine(haromszog2);
			Console.WriteLine(teglalap);
			Console.WriteLine(teglalap2);
		}
	}
}
