using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			var dictionary = new Dictionary<string, List<string>>();
			string input = Console.ReadLine();
			string[] tokens = input.Split(" | ");

			var words = new List<string>();
			var descriptions = new List<string>();
			int wordIndex = 0;
			int descriptionIndex = 1;
			for (int i = 0; i < tokens.Length; i++)
			{
				string[] wordsAndDescriptions = tokens[i].ToString().Split(": ");
				words.Add(wordsAndDescriptions[wordIndex]);
				descriptions.Add(wordsAndDescriptions[descriptionIndex]);
				if (!dictionary.ContainsKey(words[i]))
				{
					dictionary[words[i]] = new List<string>();
				}
				dictionary[words[i]].Add(descriptions[i]);
			}
			input = Console.ReadLine();
			bool listAsInput = false;
			while (true)
			{
				if (input == "End" || input == "List")
				{
					if (input == "List")
					{
						listAsInput = true;
					}
					break;
				}
				tokens = input.Split(" | ");
				for (int i = 0; i < tokens.Length; i++)
				{
					if (dictionary.ContainsKey(tokens[i]))
					{
						Console.WriteLine($"{tokens[i]}");
						foreach (var kvp in dictionary[tokens[i]].OrderByDescending(x => x.Length))
						{
							Console.WriteLine($" -{kvp}");
						}
					}
				}
				input = Console.ReadLine();
			}
			if (listAsInput)
			{
				foreach (var word in dictionary.OrderBy(x => x.Key))
				{
					Console.Write($"{word.Key} ");
				}
			}
		}
	}
}
