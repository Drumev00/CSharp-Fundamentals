using System;

namespace NxN_Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintNxNArray(n);
		}

		private static void PrintNxNArray(int n)
		{
			int[] row = new int[n];
			int[] col = new int[n];
			int[,] multiplier = new int[n, n];
			for (int i = 0; i < row.Length; i++)
			{
				for (int j = 0; j < col.Length; j++)
				{
					multiplier[j, i] += n;
				}
				
			}
			for (int i = 0; i < row.Length; i++)
			{
				for (int j = 0; j < col.Length; j++)
				{
					Console.Write($"{multiplier[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}
}
