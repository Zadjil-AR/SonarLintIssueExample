using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarLint48
{
	internal static class Program
	{
		static void Main()
		{
			string nullItem = null;
			bool value = false;

			Console.WriteLine(nullItem.ToUpper());

			if (nullItem == null) Console.WriteLine(value);
			if (nullItem != null) Console.WriteLine(value);

			switch (nullItem)
			{
				case "a":
					Console.WriteLine("yes");
					value = true;
					break;
				case "b":
					Console.WriteLine("no");
					value = false;
					break;
				default:
					Console.WriteLine("yes");
					value = true;
					break;
			}

			Console.WriteLine(value);

		}
	}
}
