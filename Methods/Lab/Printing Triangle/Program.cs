using System;

namespace Printing_Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int end = int.Parse(Console.ReadLine());
			PrintFirstPartTriangle(end);
			PrintSecondPartTriangle(end);
		}

		private static void PrintSecondPartTriangle(int end)
		{
			for (int i = end - 1; i > 0; i--)
			{
				for (int j = 1; j <= i ; j++)
				{
					Console.Write($"{j.ToString().Trim()} ");
				}
				Console.WriteLine();
			}
		}

		private static void PrintFirstPartTriangle(int end)
		{
			for (int i = 1; i <= end; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write($"{j.ToString().Trim()} ");
				}
				Console.WriteLine();
			}
		}
	}
}
