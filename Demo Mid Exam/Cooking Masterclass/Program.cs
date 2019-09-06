using System;

namespace Cooking_Masterclass
{
	class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int students = int.Parse(Console.ReadLine());
			double packageOfFlour = double.Parse(Console.ReadLine());
			double singleEgg = double.Parse(Console.ReadLine());
			double singleApron = double.Parse(Console.ReadLine());

			double totalBoughtAprons = Math.Ceiling(students + (students * 0.20));
			totalBoughtAprons = singleApron * totalBoughtAprons;


			double additionalFlour;
			if (students % 5 == 0)
			{
				additionalFlour = packageOfFlour / 5;
				packageOfFlour -= additionalFlour;
			}

			double totalEggs = (singleEgg * 10) * students;

			packageOfFlour *= students;

			double neededMoney = totalBoughtAprons + packageOfFlour + totalEggs;


			if (neededMoney <= budget)
			{
				Console.WriteLine($"Items purchased for {neededMoney:f2}$.");
			}
			else if (neededMoney > budget)
			{
				Console.WriteLine($"{neededMoney - budget:f2}$ more needed.");
			}
		}
	}
}
