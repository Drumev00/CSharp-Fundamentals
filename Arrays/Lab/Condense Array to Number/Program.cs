using System;
using System.Linq;

namespace Condense_Array_to_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();
			int[] condensed = new int[numbers.Length - 1];
			bool isValid = true;

			if (numbers.Length == 1)
			{
				condensed = new int[numbers.Length];
				isValid = false;
				Console.WriteLine(numbers[0]);
			}
			


			for (int i = 0; i < condensed.Length; i++)
			{
				for (int j = 0; j < numbers.Length - 1; j++)
				{
					condensed[j] = numbers[j] + numbers[j + 1];
					numbers[j] = condensed[j];
				}
			}
			if (isValid)
			{
				Console.WriteLine(condensed[0]);
			}
			
		}
	}
}
