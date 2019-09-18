using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Chars_In_a_String
{
	class Program
	{
		static void Main(string[] args)
		{
			string words = Console.ReadLine();
			var letters = words.ToCharArray();
			var occurrences = new Dictionary<char, int>();
			foreach (var word in letters)
			{
				if (occurrences.ContainsKey(word))
				{
					if (word != ' ')
						occurrences[word]++;
				}
				else
				{
					if (word != ' ')
						occurrences.Add(word, 1);
				}
			}
			foreach (var letter in occurrences)
			{
				Console.WriteLine($"{letter.Key} -> {letter.Value}");
			}
		}
	}
}
