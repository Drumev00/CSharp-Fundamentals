using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
	class Program
	{
		static void Main(string[] args)
		{
			var companies = new Dictionary<string, List<string>>();
			string command = Console.ReadLine();
			string[] tokens = command.Split(" -> ");

			while (command != "End")
			{
				if (!companies.ContainsKey(tokens[0]))
				{
					companies.Add(tokens[0], new List<string>());
					companies[tokens[0]].Add(tokens[1]);
				}
				else if (companies.ContainsKey(tokens[0]))
				{
					if (!companies[tokens[0]].Contains(tokens[1]))
					{
						companies[tokens[0]].Add(tokens[1]);
					}
				}
				command = Console.ReadLine();
				tokens = command.Split(" -> ");
			}
			foreach (var kvp in companies.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{kvp.Key}");
				foreach (var item in kvp.Value)
				{
					Console.WriteLine($"-- {item}");
				}
			}
		}
	}
}
