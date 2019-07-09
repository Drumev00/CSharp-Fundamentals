using System;

namespace Middle_Characters
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			PrintMiddleCharacters(word);
		}

		private static void PrintMiddleCharacters(string word)
		{
			if (word.Length % 2 == 0)
			{
				Console.Write(word[(word.Length / 2) - 1]);
				Console.Write(word[(word.Length / 2)]);
			}
			else
			{
				Console.Write(word[(word.Length / 2)]);
			}

		}
	}
}
