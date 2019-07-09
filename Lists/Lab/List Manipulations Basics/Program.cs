using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulations_Basics
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine().ToLower();
			string[] tokens = command.Split();
			int number = 0;
			int index = 0;
			while (command != "end")
			{
				if (tokens[0] == "add")
				{
					number = int.Parse(tokens[1]);
					listOfNumbers = AddNumber(listOfNumbers, number);
				}
				else if (tokens[0] == "remove")
				{
					number = int.Parse(tokens[1]);
					listOfNumbers = RemoveNumber(listOfNumbers, number);
				}
				else if (tokens[0] == "removeat")
				{
					index = int.Parse(tokens[1]);
					listOfNumbers = RemoveNumberAtIndex(listOfNumbers, index);
				}
				else if (tokens[0] == "insert")
				{
					number = int.Parse(tokens[1]);
					index = int.Parse(tokens[2]);
					listOfNumbers = IndexInsert(listOfNumbers, number, index);
				}
				command = Console.ReadLine().ToLower();
				tokens = command.Split();
			}
			Console.WriteLine(string.Join(" ", listOfNumbers));
		}

		private static List<int> IndexInsert(List<int> listOfNumbers, int number, int index)
		{
			listOfNumbers.Insert(index, number);
			return listOfNumbers;
		}

		private static List<int> RemoveNumberAtIndex(List<int> listOfNumbers, int index)
		{
			listOfNumbers.RemoveAt(index);
			return listOfNumbers;
		}

		private static List<int> RemoveNumber(List<int> listOfNumbers, int number)
		{
			listOfNumbers.Remove(number);
			return listOfNumbers;

		}

		private static List<int> AddNumber(List<int> listOfNumbers, int number)
		{
			listOfNumbers.Add(number);
			return listOfNumbers;
		}
	}
}
