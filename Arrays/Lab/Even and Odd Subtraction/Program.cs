using System;

namespace Even_and_Odd_Subtraction
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrayOfNumbers = Console.ReadLine().Split(' ');
			int[] numbers = new int[arrayOfNumbers.Length];
			int evenSum = 0;
			int oddSum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = int.Parse(arrayOfNumbers[i]);
				if (numbers[i] % 2 == 0)
				{
					evenSum += numbers[i];
				}
				else
				{
					oddSum += numbers[i];
				}
			}

			Console.WriteLine(evenSum - oddSum);

		}
	}
}
