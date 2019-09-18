using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double[]> ordersList = new Dictionary<string, double[]>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "buy")
				{
					break;
				}
				string[] command = input.Split(" ").ToArray();

				string item = command[0];
				double[] priceQuantity = { double.Parse(command[1]), double.Parse(command[2]) };

				if (!ordersList.ContainsKey(item))
				{
					ordersList.Add(item, priceQuantity);
				}
				else
				{
					double newQuantity = ordersList[item][1] + priceQuantity[1];
					ordersList[item] = new double[] { priceQuantity[0], newQuantity };
				}
			}

			foreach (var kvp in ordersList)
			{
				double totalCostItem = kvp.Value[0] * kvp.Value[1];
				Console.WriteLine($"{kvp.Key} -> {totalCostItem:f2}");
			}
		}
	}
}
