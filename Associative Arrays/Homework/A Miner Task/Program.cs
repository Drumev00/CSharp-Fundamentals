using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
	class Program
	{
		static void Main(string[] args)
		{
			var amountOfResources = new Dictionary<string, int>();
			while (true)
			{
				string resource = Console.ReadLine();
				if (resource == "stop")
					break;
				int quantity = int.Parse(Console.ReadLine());
				if (amountOfResources.ContainsKey(resource))
				{
					amountOfResources[resource] += quantity;
				}
				else
				{
					amountOfResources.Add(resource, quantity);
				}
			}
			foreach (var resource in amountOfResources)
			{
				Console.WriteLine($"{resource.Key} -> {resource.Value}");
			}
		}
	}
}
