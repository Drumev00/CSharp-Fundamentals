using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulations_Advanced
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> advancedListOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string advancedCommand = Console.ReadLine().ToLower();
			string[] tokens = advancedCommand.Split();
			int number = 0;
			while (advancedCommand != "end")
			{
				if (tokens[0] == "contains")
				{
					number = int.Parse(tokens[1]);
					NumberChecker(advancedListOfNumbers, number);
				}
				else if (tokens[0] == "printeven")
				{
					PrintEvenNumbers(advancedListOfNumbers);
				}
				else if (tokens[0] == "printodd")
				{
					PrintOddNumbers(advancedListOfNumbers);
				}
				else if (tokens[0] == "getsum")
				{
					SumTheList(advancedListOfNumbers);
				}
				else if (tokens[0] == "filter")
				{
					string condition = tokens[1];
					number = int.Parse(tokens[2]);
					FilterViaCondition(advancedListOfNumbers, condition, number);
				}
				advancedCommand = Console.ReadLine().ToLower();
				tokens = advancedCommand.Split();
			}
		}

		private static void FilterViaCondition(List<int> advancedListOfNumbers, string condition, int number)
		{
			List<int> filteredList = new List<int>(advancedListOfNumbers.Count);
			if (condition == "<")
			{
				for (int i = 0; i < advancedListOfNumbers.Count; i++)
				{
					if (advancedListOfNumbers[i] < number)
					{
						filteredList.Add(advancedListOfNumbers[i]);
					}
				}
				Console.WriteLine(string.Join(" ", filteredList));
				filteredList.Clear();
				filteredList = new List<int>(advancedListOfNumbers.Count);
			}
			else if (condition == ">")
			{
				for (int i = 0; i < advancedListOfNumbers.Count; i++)
				{
					if (advancedListOfNumbers[i] > number)
					{
						filteredList.Add(advancedListOfNumbers[i]);
					}
				}
				Console.WriteLine(string.Join(" ", filteredList));
				filteredList.Clear();
				filteredList = new List<int>(advancedListOfNumbers.Count);
			}
			else if (condition == ">=")
			{
				for (int i = 0; i < advancedListOfNumbers.Count; i++)
				{
					if (advancedListOfNumbers[i] >= number)
					{
						filteredList.Add(advancedListOfNumbers[i]);
					}
				}
				Console.WriteLine(string.Join(" ", filteredList));
				filteredList.Clear();
				filteredList = new List<int>(advancedListOfNumbers.Count);
			}
			else if (condition == "<=")
			{
				for (int i = 0; i < advancedListOfNumbers.Count; i++)
				{
					if (advancedListOfNumbers[i] <= number)
					{
						filteredList.Add(advancedListOfNumbers[i]);
					}
				}
				Console.WriteLine(string.Join(" ", filteredList));
				filteredList.Clear();
				filteredList = new List<int>(advancedListOfNumbers.Count);
			}
		}

		private static void SumTheList(List<int> advancedListOfNumbers)
		{
			int listSum = advancedListOfNumbers.Sum();
			Console.WriteLine(listSum);
		}

		private static void PrintOddNumbers(List<int> advancedListOfNumbers)
		{
			foreach (var number in advancedListOfNumbers)
			{
				if (number % 2 != 0)
				{
					Console.Write($"{number} ");
				}
			}
			Console.WriteLine();
		}

		private static void PrintEvenNumbers(List<int> advancedListOfNumbers)
		{
			foreach (var number in advancedListOfNumbers)
			{
				if (number % 2 == 0)
				{
					Console.Write($"{number} ");
				}
			}
			Console.WriteLine();
		}

		private static void NumberChecker(List<int> advancedListOfNumbers, int number)
		{
			if (advancedListOfNumbers.Contains(number))
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No such number");
			}
			
		}
	}
}

