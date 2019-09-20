using System;

namespace Character_Multiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split();
			string firstWord = input[0];
			string secondWord = input[1];
			MultiplyCharacters(firstWord, secondWord);
			Console.WriteLine(MultiplyCharacters(firstWord, secondWord));
		}

		private static int MultiplyCharacters(string firstWord, string secondWord)
		{
			int totalSum = 0;
			if (firstWord.Length == secondWord.Length)
			{
				for (int i = 0; i < firstWord.Length; i++)
				{
					totalSum += firstWord[i] * secondWord[i];
				}
			}
			else if (firstWord.Length > secondWord.Length)
			{
				for (int i = 0; i < secondWord.Length; i++)
				{
					totalSum += firstWord[i] * secondWord[i];
				}
				for (int i = firstWord.Length-1; i >= secondWord.Length; i--)
				{
					totalSum += firstWord[i];
				}
			}
			else if (secondWord.Length > firstWord.Length)
			{
				for (int i = 0; i < firstWord.Length; i++)
				{
					totalSum += firstWord[i] * secondWord[i];
				}
				for (int i = secondWord.Length-1; i >= firstWord.Length; i--)
				{
					totalSum += secondWord[i];
				}
			}
			return totalSum;
		}
	}
}
