using System;

namespace Top_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			for (int i = 0; i <= num; i++)
			{
				bool isDivisibleTo8 = EightDivider(i);

				bool isOddDigit = OddDigitChecker(i);

				if (isDivisibleTo8 && isOddDigit)
				{
					Console.WriteLine(i);
				}
			}
		}

		private static bool OddDigitChecker(int i)
		{
			bool containsOdd = false;
			while (i != 0)
			{
				int lastDigit = i % 10;
				i /= 10;

				if (lastDigit % 2 == 1)
				{
					containsOdd = true;
				}

			}

			if (containsOdd == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private static bool EightDivider(int i)
		{
			int sumOfDigits = 0;
			while (i != 0)
			{
				int lastDigit = i % 10;
				i /= 10;

				sumOfDigits += lastDigit;
			}

			if (sumOfDigits % 8 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}