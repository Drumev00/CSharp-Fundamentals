using System;
namespace Greater_of_Two_Values
{
	class Program
	{
		static void Main(string[] args)
		{
			string dataType = Console.ReadLine();
			GetMax(dataType);
		}

		private static void GetMax(string dataType)
		{
			if (dataType == "int")
			{
				int firstNumber = int.Parse(Console.ReadLine());
				int secondNumber = int.Parse(Console.ReadLine());
				int max = int.MinValue;
				if (max < firstNumber)
				{
					max = firstNumber;
				}
				if (max < secondNumber)
				{
					max = secondNumber;
				}
				Console.WriteLine(max);
			}
			else if (dataType == "char")
			{
				char firstSymbol = char.Parse(Console.ReadLine());
				char secondSymbol = char.Parse(Console.ReadLine());
				char max = char.MinValue;
				if (max < firstSymbol)
				{
					max = firstSymbol;
				}
				if (max < secondSymbol)
				{
					max = secondSymbol;
				}
				Console.WriteLine(max);
			}
			else if (dataType == "string")
			{
				int firstSum = 0;
				int secondSum = 0;

				var firstText = Console.ReadLine().ToCharArray();
				var secondText = Console.ReadLine().ToCharArray();

				for (int i = 0; i < firstText.Length; i++)
				{
					firstSum += int.Parse(firstText[i].ToString());
				}
				for (int i = 0; i < secondText.Length; i++)
				{
					secondSum += int.Parse(secondText[i].ToString());
				}

				if (firstSum > secondSum)
				{
					Console.WriteLine(firstText);
				}
				else
				{
					Console.WriteLine(secondText);
				}
			}
		}
	}
}
