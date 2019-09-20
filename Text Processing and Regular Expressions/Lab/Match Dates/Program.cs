using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var matches = Regex.Matches(input, @"\b(\d{2})([-./])([A-Z][a-z]{2})\2(\d{4})\b");

			foreach (Match match in matches)
			{
				Console.Write($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
				Console.Write(Environment.NewLine);
			}
		}
	}
}
