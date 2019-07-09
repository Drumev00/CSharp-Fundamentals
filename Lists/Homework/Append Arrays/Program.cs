using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> bigArray = Console.ReadLine().Split('|').ToList();
			List<int> numbers = new List<int>();
			for (int i = 0; i < bigArray.Count; i++)
			{
				numbers = bigArray[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

				bigArray[i] = string.Join(" ", numbers);
			}
			bigArray.Reverse();
			Console.WriteLine(string.Join(" ", bigArray));
		}
	}
}
