using System;
using System.Text.RegularExpressions;

namespace Arriving_In_Kathmandu
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			

			while (input != "Last note")
			{
				string peakPattern = @"^[A-Za-z!@#$?\d]+(?==)";
				string lengthPattern = @"(?<=)\d+(?=<)";
				string geohashPattern = @"(?<=<<)[\w\d\s\S\W\D]+";
				string text = $"{peakPattern}={lengthPattern}<<{geohashPattern}";

				bool peakIsValid = Regex.IsMatch(input, peakPattern);
				bool lengthIsValid = Regex.IsMatch(input, lengthPattern);
				bool geohashIsValid = Regex.IsMatch(input, geohashPattern);
				Regex regex = new Regex(text);

				if (!peakIsValid || !lengthIsValid || !geohashIsValid)
				{
					Console.WriteLine("Nothing found!");
				}
				else if (peakIsValid && lengthIsValid && geohashIsValid)
				{
					var peakPart = Regex.Match(input, peakPattern);
					var lengthPart = Regex.Match(input, lengthPattern);
					string number = lengthPart.ToString();
					var geohashPart = Regex.Match(input, geohashPattern);
					string geohash = geohashPart.ToString();
					if (int.Parse(number) != geohash.Length)
					{
						Console.WriteLine("Nothing found!");
					}
					else
					{
						string stringToClear = peakPart.ToString();
						foreach (var symbol in stringToClear)
						{
							if (symbol == '!' || symbol == '@' || symbol == '#' || symbol == '$' || symbol == '?')
							{
								int index = stringToClear.IndexOf(symbol);
								stringToClear = stringToClear.Remove(index, 1);
							}
						}
						Console.WriteLine($"Coordinates found! {stringToClear} -> {geohashPart}");
					}
				}
				input = Console.ReadLine();
			}
			
		}
	}
}
