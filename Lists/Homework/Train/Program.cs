using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
			int wagonsCapacity = int.Parse(Console.ReadLine());
			string command = Console.ReadLine().ToLower();
			string[] tokens = command.Split();
			int numberOfPassengers = 0;
			while (command != "end")
			{
				if (tokens[0] == "add")
				{
					numberOfPassengers = int.Parse(tokens[1]);
					if (numberOfPassengers <= wagonsCapacity)
					{
						wagons = AddWagonsWithPassengers(wagons, numberOfPassengers);
					}
				}
				else
				{
					numberOfPassengers = int.Parse(tokens[0]);
					bool meetsRequirements = false;
					for (int i = 0; i < wagons.Count; i++)
					{
						if (numberOfPassengers + wagons[i] <= wagonsCapacity)
						{
							meetsRequirements = true;
							wagons[i] += numberOfPassengers;
							if (meetsRequirements)
							{
								break;
							}
						}
					}
				}
				command = Console.ReadLine().ToLower();
				tokens = command.Split();
			}
			foreach (var wagon in wagons)
			{
				Console.Write($"{wagon} ");
			}
		}

		private static List<int> AddWagonsWithPassengers(List<int> wagons, int numberOfPassengers)
		{
			wagons.Add(numberOfPassengers);
			return wagons;
		}
	}
}
