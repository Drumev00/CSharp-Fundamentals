using System;

namespace Multiply_Evens_by_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int evenSum = GetSumOfEvenDigits(number);
			int oddSum = GetSumOfOddDigits(number);
			GetMultipleOfEvenAndOdds(evenSum, oddSum);
		}

		private static void GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
		{
			Console.WriteLine(evenSum * oddSum);
		}

		private static int GetSumOfOddDigits(int number)
		{
			int lastDigit = 0;
			int sumOfOddDigits = 0;
			while (number != 0)
			{
				lastDigit = number % 10;
				number = number / 10;
				if (lastDigit % 2 != 0)
				{
					sumOfOddDigits += lastDigit;
				}
			}
			sumOfOddDigits = (Math.Abs(sumOfOddDigits));
			return sumOfOddDigits;
		}

		private static int GetSumOfEvenDigits(int number)
		{
			int lastDigit = 0;
			int sumOfEvenDigits = 0;
			while (number != 0)
			{
				lastDigit = number % 10;
				number = number / 10;
			    if (lastDigit % 2 == 0)
				{
					sumOfEvenDigits += lastDigit;
				}
			}
			sumOfEvenDigits = (Math.Abs(sumOfEvenDigits));
			return sumOfEvenDigits;
		}
	}
}
