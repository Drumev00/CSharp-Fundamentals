using System;

namespace Characters_in_Range
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstSymbol = char.Parse(Console.ReadLine());
			char secondSymbol = char.Parse(Console.ReadLine());
			PrintSymbolsBetweenTwoCharacters(firstSymbol, secondSymbol);
		}

		private static void PrintSymbolsBetweenTwoCharacters(char firstSymbol, char secondSymbol)
		{
			if (secondSymbol > firstSymbol)
			{
				for (int i = firstSymbol + 1; i < secondSymbol; i++)
				{
					Console.Write($"{(char)i} ");
				}
			}
			else
			{
				for (int i = secondSymbol + 1; i < firstSymbol; i++)
				{
					Console.Write($"{(char)i} ");
				}
			}
		}
	}
}
