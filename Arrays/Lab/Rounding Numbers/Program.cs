using System;

namespace Rounding_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string sequenceOfNumbers = Console.ReadLine();
			string[] arraysOfNumbers = sequenceOfNumbers.Split(' ');
			double[] numbers = new double[arraysOfNumbers.Length];

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = double.Parse(arraysOfNumbers[i]);
			}

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
			}
		}
	}
}
