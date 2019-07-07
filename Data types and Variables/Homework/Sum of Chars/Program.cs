using System;

namespace Sum_of_Chars
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int result = 0;

			for (int i = 1; i <= n; i++)
			{
				char symbol = char.Parse(Console.ReadLine());
				result += symbol;
			}
			Console.WriteLine($"The sum equals: {result}");
		}
	}
}
