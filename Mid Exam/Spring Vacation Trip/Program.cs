using System;

namespace Spring_Vacation_Trip
{
	class Program
	{
		static void Main(string[] args)
		{
			int vactionDays = int.Parse(Console.ReadLine());
			double budget = double.Parse(Console.ReadLine());
			int people = int.Parse(Console.ReadLine());
			double fuelPerKilometer = double.Parse(Console.ReadLine());
			double foodExpenses = double.Parse(Console.ReadLine());
			double priceForRoom = double.Parse(Console.ReadLine());

			double currentExpenses = 0.0;
			double fuelExpenses = 0.0;
			double recievedMoney = 0;
			bool enoughMoney = true;
			double expensesForFood = 0.0;
			double hotelRoomExpenses = 0.0;

			if (people > 10)
			{
				priceForRoom = priceForRoom - (priceForRoom * 0.25);
			}
			hotelRoomExpenses = people * priceForRoom * vactionDays;
			expensesForFood = people * foodExpenses * vactionDays;
			currentExpenses = hotelRoomExpenses + expensesForFood;

			for (int i = 1; i <= vactionDays; i++)
			{
				double travelledDistance = double.Parse(Console.ReadLine());
				fuelExpenses = travelledDistance * fuelPerKilometer;
				currentExpenses += fuelExpenses;

				if (i % 7 == 0)
				{
					recievedMoney = currentExpenses / people;
					currentExpenses -= recievedMoney;
				}
				if (i % 3 == 0 || i % 5 == 0)
				{
					currentExpenses = currentExpenses + (currentExpenses * 0.40);
				}
				if (currentExpenses > budget)
				{
					enoughMoney = false;
					break;
				}
			}
			if (currentExpenses > budget)
			{
				enoughMoney = false;
			}
			if (!enoughMoney)
			{
				Console.WriteLine($"Not enough money to continue the trip. You need {Math.Abs(currentExpenses - budget):F2}$ more.");
			}
			else
			{
				Console.WriteLine($"You have reached the destination. You have {budget - currentExpenses:F2}$ budget left.");
			}
		}
	}
}
