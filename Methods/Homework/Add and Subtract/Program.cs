using System;

namespace Add_and_Subtract
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int sumResult = Summing(firstNumber, secondNumber);
			int finalResult = Subtracting(sumResult, thirdNumber);
			Console.WriteLine(finalResult);
		}

		private static int Subtracting(int sumResult, int thirdNumber)
		{
			int finalResult = sumResult - thirdNumber;
			return finalResult;
		}

		private static int Summing(int firstNumber, int secondNumber)
		{
			int result = firstNumber + secondNumber;
			return result;
		}
	}
}
