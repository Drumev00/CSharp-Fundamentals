using System;

namespace Equal_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] sequenceOfNumbers = Console.ReadLine().Split();
			int[] firstArray = new int[sequenceOfNumbers.Length];
			int firstSum = 0;

			string[] secondSequenceOfNumbers = Console.ReadLine().Split();
			int[] secondArray = new int[secondSequenceOfNumbers.Length];
			int secondSum = 0;
			bool isValid = true;

			for (int i = 0; i < firstArray.Length; i++)
			{
				firstArray[i] = int.Parse(sequenceOfNumbers[i]);
				if (firstArray[i] == int.Parse(sequenceOfNumbers[i]))
				{
					firstSum += firstArray[i];
				}
				else
				{
					Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
					isValid = false;
					break;
				}

			}

			for (int i = 0; i < secondArray.Length; i++)
			{
				secondArray[i] = int.Parse(secondSequenceOfNumbers[i]);
				if (secondArray[i] == int.Parse(sequenceOfNumbers[i]))
				{
					secondSum += secondArray[i];
				}
				else
				{
					Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
					isValid = false;
					break;
				}
			}

			if (isValid)
			{
				Console.WriteLine($"Arrays are identical. Sum: {firstSum}");
			}

		}
	}
}
