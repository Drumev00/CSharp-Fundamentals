using System;

namespace Vowels_Count
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			CountingVowels(word);
		}

		private static void CountingVowels(string word)
		{
			int count = 0;
			for (int i = 0; i <= word.Length - 1; i++)
			{
				char letter = word.ToLower()[i];
				switch (letter)
				{
					case 'a': count++; break;
					case 'u': count++; break;
					case 'o': count++; break;
					case 'e': count++; break;
					case 'i': count++; break;
				}
			}
			Console.WriteLine(count);
		}
	}
}
