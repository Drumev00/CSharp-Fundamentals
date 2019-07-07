using System;

namespace Sum_Even_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrayOfNumbers = Console.ReadLine().Split(' ');
			int[] numbers = new int [arrayOfNumbers.Length];
			int sum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = int.Parse(arrayOfNumbers[i]);
				if (numbers[i] % 2 == 0)
				{
					sum += numbers[i];
				}
			}
			Console.WriteLine(sum);
		}
	}
}
