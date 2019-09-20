using System;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var matches = Regex.Matches(input, @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
			foreach (Match match in matches)
			{
				Console.Write($"{match} ");
			}
			
		}
	}
}
