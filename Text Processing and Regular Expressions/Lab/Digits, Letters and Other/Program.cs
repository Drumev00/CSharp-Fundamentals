using System;

namespace Digits__Letters_and_Other
{
	class Program
	{
		static void Main(string[] args)
		{
			string combination = Console.ReadLine();

			foreach (var digit in combination)
			{
				if (char.IsDigit(digit))
				{
					Console.Write(digit);
					int index = combination.IndexOf(digit);
					combination = combination.Remove(index, 1);
				}
			}
			Console.Write(Environment.NewLine);
			foreach (var letter in combination)
			{
				if (char.IsLetter(letter))
				{
					Console.Write(letter);
					int index = combination.IndexOf(letter);
					combination = combination.Remove(index, 1);
				}
			}
			Console.Write(Environment.NewLine);
			foreach (var symbol in combination)
			{
				Console.Write(symbol);
			}
		}
	}
}
