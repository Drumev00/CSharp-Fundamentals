using System;
using System.Collections.Generic;
using System.Linq;

namespace Activation_Key
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			List<string> potentialKeys = input.Split("&").ToList();
			List<string> validKeys = new List<string>();
			int counter = 0;
			for (int i = 0; i < potentialKeys.Count; i++)
			{
				bool isValid = true;
				if (potentialKeys[i].Length != 16 && potentialKeys[i].Length != 25)
				{
					isValid = false;
					continue;
				}
				foreach (var letter in potentialKeys[i])
				{
					if (!char.IsLetterOrDigit(letter))
					{
						isValid = false;
						break;
					}
				}
				if (isValid)
				{
					validKeys.Add(potentialKeys[i]);
				}
			}
			for (int i = 0; i < validKeys.Count; i++)
			{
				if (validKeys[i].Length == 16)
				{
					foreach (var symbol in validKeys[i])
					{
						if (char.IsDigit(symbol))
						{
							int digit = int.Parse(symbol.ToString());
							int toSubtract = 9;
							toSubtract -= digit;
							string word = toSubtract.ToString();
							char newLetter = word[0];
							int startIndex = validKeys[i].IndexOf(symbol, counter, 1);
							counter++;
							validKeys[i] = validKeys[i].Remove(startIndex, 1);
							validKeys[i] = validKeys[i].Insert(startIndex, newLetter.ToString());
						}
						else if (char.IsLetter(symbol))
						{
							string word = symbol.ToString();
							word = word.ToUpper();
							char newLetter = word[0];
							validKeys[i] = validKeys[i].Replace(symbol, newLetter);
							counter++;
						}
					}
					validKeys[i] = validKeys[i].Insert(4, "-");
					validKeys[i] = validKeys[i].Insert(9, "-");
					validKeys[i] = validKeys[i].Insert(14, "-");
					counter = 0;
				}
				else if (validKeys[i].Length == 25)
				{
					foreach (var symbol in validKeys[i])
					{
						if (char.IsDigit(symbol))
						{
							int digit = int.Parse(symbol.ToString());
							int toSubtract = 9;
							toSubtract -= digit;
							string word = toSubtract.ToString();
							char newLetter = word[0];
							int startIndex = validKeys[i].IndexOf(symbol, counter);
							counter++;
							validKeys[i] = validKeys[i].Remove(startIndex, 1);
							validKeys[i] = validKeys[i].Insert(startIndex, newLetter.ToString());
						}
						else if (char.IsLetter(symbol))
						{
							string word = symbol.ToString();
							word = word.ToUpper();
							char newLetter = word[0];
							validKeys[i] = validKeys[i].Replace(symbol, newLetter);
							counter++;
						}
					}
					validKeys[i] = validKeys[i].Insert(5, "-");
					validKeys[i] = validKeys[i].Insert(11, "-");
					validKeys[i] = validKeys[i].Insert(17, "-");
					validKeys[i] = validKeys[i].Insert(23, "-");
					counter = 0;
				}
			}
			Console.WriteLine(string.Join(", ", validKeys));
		}
	}
}
