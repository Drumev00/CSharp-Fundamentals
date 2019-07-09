using System;

namespace Sign_of_Integer_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			short number = short.Parse(Console.ReadLine());
			PrintingSign(number);
		}

		private static void PrintingSign(short number)
		{
			if (number > 0)
			{
				Console.WriteLine($"The number {number} is positive.");
			}
			else if (number == 0)
			{
				Console.WriteLine($"The number {number} is zero.");
			}
			else
			{
				Console.WriteLine($"The number {number} is negative.");
			}
		}
	}
}
