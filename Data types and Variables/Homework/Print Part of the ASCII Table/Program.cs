using System;

namespace Print_Part_of_the_ASCII_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			short begining = short.Parse(Console.ReadLine());
			short ending = short.Parse(Console.ReadLine());

			for (short i = begining; i <= ending; i++)
			{
				Console.Write($"{(char)i} ");
			}
		}
	}
}
