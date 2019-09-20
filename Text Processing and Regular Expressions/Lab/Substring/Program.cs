using System;

namespace Substring
{
	class Program
	{
		static void Main(string[] args)
		{
			string needsRemove = Console.ReadLine();
			string word = Console.ReadLine();
			while (word.Contains(needsRemove))
			{
				 word = word.Replace(needsRemove, string.Empty);
			}
			Console.WriteLine(word);
		}
	}
}
