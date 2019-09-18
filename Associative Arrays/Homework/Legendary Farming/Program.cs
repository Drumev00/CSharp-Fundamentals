using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
	class Program
	{
		static void Main(string[] args)
		{
			var neededItems = new Dictionary<string, int>
			{
				["shards"] = 0,
				["fragments"] = 0,
				["motes"] = 0
			};
			var junk = new SortedDictionary<string, int>();
			string collectedItems = Console.ReadLine().ToLower();

			List<string> lowerCase = collectedItems.Split().ToList();
			bool obtained = false;

			while (!obtained)
			{
				while (lowerCase.Count > 0)
				{
					if (lowerCase[1] != "shards"
						&& lowerCase[1] != "fragments"
						&& lowerCase[1] != "motes")
					{
						if (!junk.ContainsKey(lowerCase[1]))
						{
							junk.Add(lowerCase[1], int.Parse(lowerCase[0]));
						}
						else
						{
							junk[lowerCase[1]] += int.Parse(lowerCase[0]);
						}
						lowerCase.RemoveAt(0);
						lowerCase.RemoveAt(0);
						if (lowerCase.Count == 0)
							break;
					}
					if (lowerCase[1] == "shards")
					{
						int amountOfShards = int.Parse(lowerCase[0]);
						neededItems["shards"] += amountOfShards;
						lowerCase.RemoveAt(0);
						lowerCase.RemoveAt(0);
						if (neededItems["shards"] >= 250)
						{
							neededItems["shards"] -= 250;
							Console.WriteLine("Shadowmourne obtained!");
							obtained = true;
							break;
						}
						if (lowerCase.Count == 0)
							break;
					}
					if (lowerCase[1] == "fragments")
					{
						int amountOfFragments = int.Parse(lowerCase[0]);
						neededItems["fragments"] += amountOfFragments;
						lowerCase.RemoveAt(0);
						lowerCase.RemoveAt(0);
						if (neededItems["fragments"] >= 250)
						{
							neededItems["fragments"] -= 250;
							Console.WriteLine("Valanyr obtained!");
							obtained = true;
							break;
						}
						if (lowerCase.Count == 0)
							break;
					}
					if (lowerCase[1] == "motes")
					{
						int amountOfMotes = int.Parse(lowerCase[0]);
						neededItems["motes"] += amountOfMotes;
						lowerCase.RemoveAt(0);
						lowerCase.RemoveAt(0);
						if (neededItems["motes"] >= 250)
						{
							neededItems["motes"] -= 250;
							Console.WriteLine("Dragonwrath obtained!");
							obtained = true;
							break;
						}
						if (lowerCase.Count == 0)
							break;
					}
				}
				if (!obtained)
				{
					collectedItems = Console.ReadLine().ToLower();
					lowerCase = collectedItems.Split().ToList();
				}
			}
			var result = neededItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
			
			foreach (var item in result)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
			foreach (var item in junk)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}
	}
}
