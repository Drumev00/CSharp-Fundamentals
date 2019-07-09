using System;

namespace Re_eat_String
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int multiplier = int.Parse(Console.ReadLine());
			string result = MultipliedString(input, multiplier);
			Console.WriteLine(result);
		}

		static string MultipliedString(string input, int multiplier)
		{
			for (int i = 1; i < multiplier; i++)
			{
				Console.Write(input);
			}
			return input;
		}
	}
}
