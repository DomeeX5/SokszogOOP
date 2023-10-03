using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
	internal class Sokszogek
	{
		private List<Sokszog> sokszogek;
		private static Random RND = new Random();
		public Sokszogek()
		{
			sokszogek = new List<Sokszog>();
			for (int i = 0; i < 10; i++)
			{
				int sokszog = RND.Next(3);
				switch (sokszog)
				{
					case 0:
						sokszogek.Add(new Teglalap());
						break;
					case 1:
						sokszogek.Add(new Haromszog());
						break;
					case 2:
						sokszogek.Add(new Paralelogramma());
						break;
					default:
						break;
				}
			}
		}

		public double OsszKerulet()
		{
			double osszKerulet = 0;
			foreach (var sokszog in sokszogek)
			{
				osszKerulet += sokszog.GetKerulet();
			}
			return osszKerulet;
		}
		public double OsszTerulet()
		{
			double osszTerulet = 0;
			foreach (var sokszog in sokszogek)
			{
				osszTerulet += sokszog.GetTerulet();
			}
			return osszTerulet;
		}

		public int MaxTerulet()
		{
			int maxIndex = 0;
			for (int i = 1; i < sokszogek.Count; i++)
			{
				if (sokszogek[i].GetTerulet() > sokszogek[maxIndex].GetTerulet())
				{
					maxIndex = i;
				}
			}
			return maxIndex + 1;
		}


		public override string ToString()
		{
			var sb = new StringBuilder("Sokszögek:");
			foreach (var sokszog in sokszogek)
			{
				sb.AppendLine();
				sb.Append($"  {sokszog.ToString()}");
			}
			sb.AppendLine($"\n\nA listában lévő sökszögek összkerülete: {OsszKerulet()}\n Területe: {OsszTerulet()}\n Legnagyobb területű elem sorszáma: {MaxTerulet()}.");
			return sb.ToString();
		}
	}
}
