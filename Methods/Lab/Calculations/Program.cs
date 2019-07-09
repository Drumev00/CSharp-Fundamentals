using System;

namespace Calculations
{
	class Program
	{
		static void Main(string[] args)
		{
			string action = Console.ReadLine();
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());

			Summing(action, firstNumber, secondNumber);
			Multiplying(action, firstNumber, secondNumber);
			Subtracting(action, firstNumber, secondNumber);
			Dividing(action, firstNumber, secondNumber);

		}

		private static void Dividing(string action, int firstNumber, int secondNumber)
		{
			if (action == "divide")
			{
				int result = firstNumber / secondNumber;
				Console.WriteLine(result);
			}
		}

		private static void Subtracting(string action, int firstNumber, int secondNumber)
		{
			if (action == "subtract")
			{
				int result = firstNumber - secondNumber;
				Console.WriteLine(result);
			}
		}

		private static void Multiplying(string action, int firstNumber, int secondNumber)
		{
			if (action == "multiply")
			{
				int result = firstNumber * secondNumber;
				Console.WriteLine(result);
			}
		}

		private static void Summing(string action, int firstNumber, int secondNumber)
		{
			if (action == "add")
			{
				int result = firstNumber + secondNumber;
				Console.WriteLine(result);
			}
		}
	}
}
