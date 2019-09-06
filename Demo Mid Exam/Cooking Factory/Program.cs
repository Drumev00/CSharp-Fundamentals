using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			List<int> batches = new List<int>();
			List<int> totalQuality = new List<int>();
			int quality = 0;

			List<double> averageQuality = new List<double>();
			double average = 0;
			int max = int.MinValue;

			int counter = 0;
			List<int> bestBatch = new List<int>();

			while (command != "Bake It!")
			{
				batches = command.Split('#').Select(int.Parse).ToList();
				for (int i = 0; i < batches.Count; i++)
				{
					quality += batches[i];
				}
				totalQuality.Add(quality);
				average = (double)totalQuality[counter] / batches.Count;
				averageQuality.Add(average);
				if (max <= quality)
				{
					max = quality;
					bestBatch = batches;
				}

				command = Console.ReadLine();
				counter++;
				quality = 0;
			}
			for (int i = 0; i < counter - 1; i++)
			{
				if (totalQuality[i] == totalQuality[i+1] && averageQuality[i] > averageQuality[i+1])
				{
					max = totalQuality[i];
				}
				else if (totalQuality[i] == totalQuality[i + 1] && averageQuality[i] < averageQuality[i + 1])
				{
					max = totalQuality[i+1];
				}
			}
			Console.WriteLine($"Best Batch quality: {max}");
			Console.WriteLine(string.Join(" ", bestBatch));
		}
	}
}
