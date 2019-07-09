using System;
using System.Collections.Generic;

namespace House_Party
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCommands = int.Parse(Console.ReadLine());
			string names = Console.ReadLine();
			string[] tokens = names.Split();
			List<string> peopleWhoWillCome = new List<string>(numberOfCommands);
			bool isInTheList = false;
			for (int i = 0; i < numberOfCommands; i++)
			{
				if (tokens[2] != "not")
				{
					for (int j = 0; j < peopleWhoWillCome.Count; j++)
					{
						if (peopleWhoWillCome[j] == tokens[0])
						{
							isInTheList = true;
						}
					}
					if (!isInTheList)
					{
						peopleWhoWillCome.Add(tokens[0]);
					}
					else
					{
						Console.WriteLine($"{tokens[0]} is already in the list!");
					}
					isInTheList = false;
				}
				else
				{
					for (int j = 0; j < peopleWhoWillCome.Count; j++)
					{
						if (peopleWhoWillCome[j] == tokens[0])
						{
							isInTheList = true;
						}
					}
					if (isInTheList)
					{
						peopleWhoWillCome.Remove(tokens[0]);
					}
					else
					{
						Console.WriteLine($"{tokens[0]} is not in the list!");
					}
					isInTheList = false;
				}
				if (i == numberOfCommands - 1)
				{
					break;
				}
				names = Console.ReadLine();
				tokens = names.Split();
			}
			foreach (var name in peopleWhoWillCome)
			{
				Console.WriteLine(name);
			}

		}
	}
}
