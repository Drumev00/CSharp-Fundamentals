using System;
using System.Collections.Generic;
using System.Linq;

namespace On_the_Way_To_Annapurna
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] tokens = input.Split(new string[] { "->", "," }, StringSplitOptions.RemoveEmptyEntries);
			var storesAndProducts = new Dictionary<string, List<string>>();

			while (input != "END")
			{
				string action = tokens[0];
				string store = tokens[1];

				if (action == "Add" && tokens.Length < 3)
				{
					if (!storesAndProducts.ContainsKey(store))
					{
						storesAndProducts[store] = new List<string>();
					}
					storesAndProducts[store].Add(tokens[3]);
				}
				else if (action == "Add" && tokens.Length >= 2)
				{
					if (!storesAndProducts.ContainsKey(store))
					{
						storesAndProducts[store] = new List<string>();
					}
					for (int i = 2; i < tokens.Length; i++)
					{
						storesAndProducts[store].Add(tokens[i]);
					}
				}
				else if (action == "Remove")
				{
					if (storesAndProducts.ContainsKey(store))
					{
						storesAndProducts.Remove(store);
					}
				}

				input = Console.ReadLine();
				tokens = input.Split(new string[] { "->", "," }, StringSplitOptions.RemoveEmptyEntries);
			}
			Console.WriteLine("Stores list:");
			foreach (var kvp in storesAndProducts.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
			{
				Console.WriteLine($"{kvp.Key}");
				foreach (var item in kvp.Value)
				{
					Console.WriteLine($"<<{item}>>");
				}
			}
		}
	}
}
