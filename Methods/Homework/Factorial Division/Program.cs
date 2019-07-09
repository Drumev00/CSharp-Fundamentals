using System;

namespace Factorial_Division
{
	class Program
	{
		static void Main(string[] args)
		{
			long firstNumber = long.Parse(Console.ReadLine());
			long secondNumber = long.Parse(Console.ReadLine());
			long firstFactorial = CalculateFirstFactorial(firstNumber);
			long secondFactorial = CalculateSecondFactorial(secondNumber);

			long result = firstFactorial / secondFactorial;
			Console.WriteLine($"{result:f2}");
		}

		static long CalculateSecondFactorial(long secondNumber)
		{
			long sum = 1;
			for (int i = 2; i <= secondNumber; i++)
			{
				sum *= i;
			}
			return sum;
		}

		static long CalculateFirstFactorial(long firstNumber)
		{
			long sum = 1;
			for (int i = 2; i <= firstNumber; i++)
			{
				sum *= i;
			}
			return sum;
		}
	}
}
