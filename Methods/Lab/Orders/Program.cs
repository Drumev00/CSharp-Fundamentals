using System;

namespace Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());
			CalculateOrder(product, quantity);
		}

		private static void CalculateOrder(string product, double quantity)
		{
			double result = 0;
			if (product == "coffee")
			{
				result = quantity * 1.50;
			}
			else if (product == "water")
			{
				result = quantity * 1.00;
			}
			else if (product == "coke")
			{
				result = quantity * 1.40;
			}
			else if (product == "snacks")
			{
				result = quantity * 2.00;
			}
			Console.WriteLine($"{result:F2}");
		}
	}
}
