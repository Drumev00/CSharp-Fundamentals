using System;
using System.Text.RegularExpressions;

namespace Match_a_Phone_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var matches = Regex.Matches(input, @"\+359([ -])2\1\d{3}\1\d{4}\b");

			for (int i = 0; i < matches.Count; i++)
			{
				if (i == matches.Count-1)
				{
					Console.Write($"{matches[i]}");
					break;
				}
				Console.Write($"{matches[i]}, ");
			}
		}
	}
}
