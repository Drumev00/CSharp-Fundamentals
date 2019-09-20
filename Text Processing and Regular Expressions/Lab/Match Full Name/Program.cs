using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var matches = Regex.Matches(input,  @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

			foreach (Match match in matches)
			{
				Console.Write($"{match} ");
			}
			
		}
	}
}
