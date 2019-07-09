using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> distancesToPokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
			int increaseOrDecrease = 0;
			int result = 0;
			while (distancesToPokemons.Count != 0)
			{
				int removeIndex = int.Parse(Console.ReadLine());
				if (removeIndex < 0)
				{
					int lastToFirst = distancesToPokemons.Last();
					distancesToPokemons.Insert(0, lastToFirst);
				}
				else if (removeIndex >= distancesToPokemons.Count)
				{
					int firstToLast = distancesToPokemons.First();
					distancesToPokemons.Add(firstToLast);
				}
				increaseOrDecrease = distancesToPokemons[removeIndex];
				result += increaseOrDecrease;
				distancesToPokemons.RemoveAt(removeIndex);
				for (int i = 0; i < distancesToPokemons.Count; i++)
				{
					if (distancesToPokemons[i] <= increaseOrDecrease)
					{
						distancesToPokemons[i] += increaseOrDecrease;
					}
					else if (distancesToPokemons[i] > increaseOrDecrease)
					{
						distancesToPokemons[i] -= increaseOrDecrease;
					}
				}
			}
			Console.WriteLine(result);
		}
	}
}
