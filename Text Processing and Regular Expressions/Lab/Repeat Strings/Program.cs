using System;

namespace Repeat_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();
			foreach (var word in words)
			{
				int n = word.Length;
				for (int i = 0; i < n; i++)
				{
					Console.Write(word);
				}
			}
		}
	}
}
