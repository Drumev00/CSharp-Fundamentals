using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split().ToArray();
			var occurrences = new Dictionary<string, int>();

			foreach (var item in input)
			{
				string inputInLower = item.ToLower();
				if (occurrences.ContainsKey(inputInLower))
				{
					occurrences[inputInLower]++;
				}
				else
				{
					occurrences.Add(inputInLower, 1);
				}
			}
			foreach (var item in occurrences)
			{
				if (item.Value % 2 != 0)
				{
					Console.Write(item.Key + " ");
				}
			}
		}
	}
}
