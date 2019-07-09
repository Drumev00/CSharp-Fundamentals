using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> result = new List<int>(firstList.Count + secondList.Count);
			int max = int.MinValue;
			if (firstList.Count > secondList.Count)
			{
				max = firstList.Count;
			}
			else
			{
				max = secondList.Count;
			}

			for (int i = 0; i < max; i++)
			{
				if (firstList.Count > 0)
				{
					result.Add(firstList[0]);
					firstList.RemoveAt(0);
				}
				if (secondList.Count > 0)
				{
					result.Add(secondList[0]);
					secondList.RemoveAt(0);
				}
			}
			Console.WriteLine(string.Join(" ", result));
		}
	}
}
