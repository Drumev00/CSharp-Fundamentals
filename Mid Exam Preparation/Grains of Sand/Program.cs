using System;
using System.Collections.Generic;
using System.Linq;

namespace Grains_of_Sand
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> allGrains = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();
			string[] tokens = command.Split();
			int value = 0;
			int replacement = 0;
			while (command != "Mort")
			{
				if (tokens[0] == "Add")
				{
					value = int.Parse(tokens[1]);
					allGrains.Add(value);
				}
				else if (tokens[0] == "Remove")
				{
					value = int.Parse(tokens[1]);
					allGrains = RemoveValue(allGrains, value);
				}
				else if (tokens[0] == "Replace")
				{
					value = int.Parse(tokens[1]);
					replacement = int.Parse(tokens[2]);
					allGrains = ReplaceValue(allGrains, value, replacement);
				}
				else if (tokens[0] == "Increase")
				{
					value = int.Parse(tokens[1]);
					allGrains = IncreaseValue(allGrains, value);
				}
				else if (tokens[0] == "Collapse")
				{
					value = int.Parse(tokens[1]);
					allGrains = CollapseValues(allGrains, value);
				}
				command = Console.ReadLine();
				tokens = command.Split();
			}
			Console.WriteLine(string.Join(" ", allGrains));
		}

		private static List<int> CollapseValues(List<int> allGrains, int value)
		{
			for (int i = 0; i < allGrains.Count; i++)
			{
				if (allGrains[i] < value)
				{
					allGrains.RemoveAt(i);
					i--;
				}
			}
			return allGrains;
		}

		private static List<int> IncreaseValue(List<int> allGrains, int value)
		{
			int increaseValue = 0;
			bool neededNumberExists = false;
			for (int i = 0; i < allGrains.Count; i++)
			{
				if (allGrains[i] >= value)
				{
					increaseValue = allGrains[i];
					neededNumberExists = true;
					break;
				}
			}
			if (neededNumberExists)
			{
				for (int i = 0; i < allGrains.Count; i++)
				{
					allGrains[i] += increaseValue;
				}
			}
			else if (!neededNumberExists)
			{
				increaseValue = allGrains[allGrains.Count - 1];
				for (int i = 0; i < allGrains.Count; i++)
				{
					allGrains[i] += increaseValue;
				}
			}
			return allGrains;
		}

		private static List<int> ReplaceValue(List<int> allGrains, int value, int replacement)
		{
			if (allGrains.Contains(value))
			{
				int indexOf = allGrains.IndexOf(value);
				allGrains[indexOf] = replacement;
			}
			return allGrains;
		}

		private static List<int> RemoveValue(List<int> allGrains, int value)
		{
			if (allGrains.Contains(value))
			{
				allGrains.Remove(value);
			}
			else if (value >= 0 && value < allGrains.Count)
			{
				allGrains.RemoveAt(value);
			}
			return allGrains;
		}
	}
}
