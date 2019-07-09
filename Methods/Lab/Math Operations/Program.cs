using System;

namespace Math_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			double firstNumber = double.Parse(Console.ReadLine());
			char signForAction = char.Parse(Console.ReadLine());
			double secondNumber = double.Parse(Console.ReadLine());
			double result = Calculations(firstNumber, signForAction, secondNumber);
			Console.WriteLine(result);
		}

		private static double Calculations(double firstNumber, char signForAction, double secondNumber)
		{
			double result = 0;
			if (signForAction == '/')
			{
				result = firstNumber / secondNumber;
			}
			else if (signForAction == '*')
			{
				result = firstNumber * secondNumber;
			}
			else if (signForAction == '+')
			{
				result = firstNumber + secondNumber;
			}
			else if (signForAction == '-')
			{
				result = firstNumber - secondNumber;
			}
			return result;
		}
	}
}
