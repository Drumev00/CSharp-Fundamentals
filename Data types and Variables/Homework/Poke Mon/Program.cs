using System;

namespace Poke_Mon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePower = int.Parse(Console.ReadLine());
			int distance = int.Parse(Console.ReadLine());
			int exhaustionFactor = int.Parse(Console.ReadLine());
			int pokedTargets = 0;
			int halfPokePower = pokePower;

			while (pokePower >= distance)
			{
				pokePower = pokePower - distance;
				pokedTargets++;
				if (pokePower == halfPokePower / 2)
				{
					pokePower /= exhaustionFactor;
				}
			}
			Console.WriteLine(pokePower);
			Console.WriteLine(pokedTargets);
		}
	}
}
