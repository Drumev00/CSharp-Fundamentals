using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			int[] bombPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int bombNumber = bombPower[0];
			int powerNumber = bombPower[1];

			Remove(numbers, bombNumber, powerNumber);

			Console.WriteLine(numbers.Sum());

		}
		private static List<int> Remove(List<int> numbers, int bombNumber, int powerNumber)
		{
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] == bombNumber)
				{
					for (int j = i; j >= i - powerNumber; j--)
					{
						numbers[j] = 0;

						if (j == 0)
						{
							break;
						}
					}

					for (int k = i; k <= i + powerNumber; k++)
					{

						numbers[k] = 0;

						if (k == numbers.Count - 1)
						{
							break;
						}
					}
				}
			}
			return numbers;
		}
	}
}
