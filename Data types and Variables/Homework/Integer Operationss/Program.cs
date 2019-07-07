using System;

namespace Integer_Operationss
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int fourthNumber = int.Parse(Console.ReadLine());

			int addition = firstNumber + secondNumber;
			int divide = addition / thirdNumber;
			int result = divide * fourthNumber;

			Console.WriteLine(result);
		}
	}
}
