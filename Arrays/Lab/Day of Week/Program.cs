using System;

namespace Day_of_Week
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] day = { "Monday", // 0
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday" }; // 6

			int currentDay = int.Parse(Console.ReadLine());

			if (currentDay < 1 || currentDay > 7)
			{
				Console.WriteLine("Invalid day!");
			}
			else
			{
				Console.WriteLine(day[currentDay - 1]);
			}

		}
	}
}
