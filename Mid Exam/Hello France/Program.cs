using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello_France
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> clothesAndTheirPrice = Console.ReadLine().Split("|").ToList();
			List<double> newPrices = new List<double>();

			double budget = double.Parse(Console.ReadLine());
			double startBudget = budget;

			double price = 0.0;
			int indexOfItem = 0;

			double clothesMaxPrice = 50.00;
			double shoesMaxPrice = 35.00;
			double accessoriesMaxPrice = 20.50;

			// Clothes->43.30|Shoes->25.25|Clothes->36.52|Clothes->20.90|Accessories->15.60
			for (int i = 0; i < clothesAndTheirPrice.Count; i++)
			{
				List<string> separatedPriceByItems = clothesAndTheirPrice[indexOfItem].Split("->").ToList();
				price = double.Parse(separatedPriceByItems[1]);
				if (budget >= price)
				{
					bool validPrice = false;
					if (separatedPriceByItems[0] == "Clothes" && price <= clothesMaxPrice)
					{
						validPrice = true;
					}
					else if (separatedPriceByItems[0] == "Shoes" && price <= shoesMaxPrice)
					{
						validPrice = true;
					}
					else if (separatedPriceByItems[0] == "Accessories" && price <= accessoriesMaxPrice)
					{
						validPrice = true;
					}
					if (validPrice)
					{
						budget -= price;
						price = price + (price * 0.40);
						newPrices.Add(price);
					}
				}
				indexOfItem++;
			}
			double totalSold = 0;
			for (int i = 0; i < newPrices.Count; i++)
			{
				totalSold += newPrices[i];
			}
			double profit = budget + (totalSold - startBudget);
			double currentbudget = budget + totalSold;
			foreach (var item in newPrices)
			{
				Console.Write($"{item:F2} ");
			}
			Console.WriteLine();
			Console.WriteLine($"Profit: {profit:F2}");
			if (currentbudget >= 150)
			{
				Console.WriteLine("Hello, France!");
			}
			else
			{
				Console.WriteLine("Time to go.");
			}
		}
	}
}
