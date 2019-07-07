using System;

namespace Spice_Must_Flow
{
	class Program
	{
		static void Main(string[] args)
		{
			int startingYield = int.Parse(Console.ReadLine());
			int currentSpice = 0;
			int days = 0;

			while (startingYield >= 100)
			{
				currentSpice += startingYield - 26;
				startingYield -= 10;
				days++;
			}

			if (currentSpice >= 26)
			{
				currentSpice -= 26;
			}
			Console.WriteLine(days);
			Console.WriteLine(currentSpice);
		}
	}
}
