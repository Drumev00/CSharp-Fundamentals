using System;

namespace Sum_Digits
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			int lastDigit = 1;

			while (n > 0)
			{
				lastDigit = n % 10;
				n /= 10;
				sum += lastDigit;
			}
			Console.WriteLine(sum);
		}
	}
}
