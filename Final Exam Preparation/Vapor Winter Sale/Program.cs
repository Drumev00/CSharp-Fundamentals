using System;
using System.Collections.Generic;
using System.Linq;

namespace Vapor_Winter_Sale
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var games = new Dictionary<string, DLC>();
			string[] splittedInput = input.Split(", ");
			
			for (int i = 0; i < splittedInput.Length; i++)
			{
				if (splittedInput[i].Contains('-'))
				{
					string[] gameAndPrice = splittedInput[i].Split("-");
					if (!games.ContainsKey(gameAndPrice[0]))
					{
						games[gameAndPrice[0]] = new DLC();
					}
					games[gameAndPrice[0]].Price = double.Parse(gameAndPrice[1]);
				}
				else if (splittedInput[i].Contains(':'))
				{
					string[] gameAndDlc = splittedInput[i].Split(":");
					if (games.ContainsKey(gameAndDlc[0]))
					{
						games[gameAndDlc[0]].Name = gameAndDlc[1];
						games[gameAndDlc[0]].Price = games[gameAndDlc[0]].Price + (games[gameAndDlc[0]].Price * 0.20);
					}
				}
			}
			foreach (var kvp in games.Where(x => x.Value.Name != null).OrderBy(x => x.Value.Price))
			{
				kvp.Value.Price = kvp.Value.Price - (kvp.Value.Price * 0.50);
				Console.WriteLine($"{kvp.Key} - {kvp.Value.Name} - {kvp.Value.Price:F2}");
			}
			foreach (var kvp in games.Where(x => x.Value.Name == null).OrderByDescending(x => x.Value.Price))
			{
				kvp.Value.Price = kvp.Value.Price - (kvp.Value.Price * 0.20);
				Console.WriteLine($"{kvp.Key} - {kvp.Value.Price:F2}");
			}
		}
	}
	class DLC
	{
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
