using System;
using System.Collections.Generic;
using System.Linq;

namespace Bread_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> command = Console.ReadLine().Split('|').ToList();
			int energy = 100;
			int coins = 100;
			int index = 0;
			string[] tokens = command[index].Split('-').ToArray();
			int number = 0;
			string ingredient = string.Empty;
			bool bankrupt = false;


			// rest-2|order-10|eggs-100|rest-10 

			for (int i = 0; i < command.Count; i++)
			{
				if (tokens[0] == "rest")
				{
					number = int.Parse(tokens[1]);
					if (energy + number <= 100 && energy + number > 0)
					{
						energy += number;
						Console.WriteLine($"You gained {number} energy.");
					}
					else
					{
						Console.WriteLine($"You gained 0 energy.");
					}
					Console.WriteLine($"Current energy: {energy}.");
				}
				else if (tokens[0] == "order")
				{
					number = int.Parse(tokens[1]);
					if (energy - 30 >= 0 && energy - 30 <= 100)
					{
						coins += number;
						energy -= 30;
						Console.WriteLine($"You earned {number} coins.");
					}
					else if (energy - 30 < 0)
					{
						energy += 50;
						Console.WriteLine("You had to rest!");
					}
				}
				else
				{
					ingredient = tokens[0];
					number = int.Parse(tokens[1]);
					coins -= number;
					if (coins > 0)
					{
						Console.WriteLine($"You bought {ingredient}.");
					}
					else
					{
						bankrupt = true;
						Console.WriteLine($"Closed! Cannot afford {ingredient}.");
						break;
					}
				}
				index++;
				if (index >= command.Count)
				{
					break;
				}
				tokens = command[index].Split('-').ToArray();
			}
			if (!bankrupt)
			{
				Console.WriteLine("Day completed!");
				Console.WriteLine($"Coins: {coins}");
				Console.WriteLine($"Energy: {energy}");
			}

		}
	}
}
