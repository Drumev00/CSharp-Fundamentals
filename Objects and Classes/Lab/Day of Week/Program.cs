using System;
using System.Globalization;

namespace Day_of_Week
{
	class Program
	{
		static void Main(string[] args)
		{
			// 18-04-2016
			string input = Console.ReadLine();
			DateTime dayOfWeek = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine(dayOfWeek.DayOfWeek);
		}
	}

}
