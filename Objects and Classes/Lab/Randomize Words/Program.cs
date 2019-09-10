using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			// Welcome to SoftUni and have fun learning programming
			List<string> words = Console.ReadLine().Split().ToList();
			Random rnd = new Random();
			for (int i = 0; i < words.Count; i++)
			{
				int index = rnd.Next(0, words.Count);
				words.Insert(index, words[i]);
				words.RemoveAt(i);
				Console.WriteLine(words[i]);
			}
			
		}
	}
}
