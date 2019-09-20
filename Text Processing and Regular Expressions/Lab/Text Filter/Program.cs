using System;

namespace Text_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] bannedWords = Console.ReadLine().Split(", ");
			string text = Console.ReadLine();
			char ch = '*';

			foreach (var word in bannedWords)
			{
				if (text.Contains(word))
				{
					int count = word.Length;
					var replacement = new string(ch, count);
					text = text.Replace(word, replacement);
				}
			}
			Console.WriteLine(text);
		}
	}
}
