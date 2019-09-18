using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
			var counts = new SortedDictionary<double, int>();

			foreach (var number in numbers)
			{
				if (counts.ContainsKey(number))
				{
					counts[number]++;
				}
				else
				{
					counts.Add(number, 1);
				}
			}
			foreach (var count in counts)
			{
				Console.WriteLine($"{count.Key} -> {count.Value}");
			}
		}
	}
}
