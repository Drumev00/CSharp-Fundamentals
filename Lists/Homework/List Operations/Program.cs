using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = string.Empty;
			int element = 0;
			int index = 0;
			int count = 0;
			while((command = Console.ReadLine().ToLower()) != "end")
			{
				string[] tokens = command.Split();
				if (tokens[0] == "add")
				{
					element = int.Parse(tokens[1]);
					numbers = AddNumber(numbers, element);
				}
				else if (tokens[0] == "insert")
				{
					element = int.Parse(tokens[1]);
					index = int.Parse(tokens[2]);
					if (index >= numbers.Count || index < 0)
					{
						Console.WriteLine("Invalid index");
					}
					else
					{
						numbers = InsertNumber(numbers, element, index);
					}
				}
				else if (tokens[0] == "remove")
				{
					index = int.Parse(tokens[1]);
					if (index >= numbers.Count || index < 0)
					{
						Console.WriteLine("Invalid index");
					}
					else
					{
						numbers = RemoveAtIndex(numbers, index);
					}
				}
				else if (tokens[0] == "shift" && tokens[1] == "left")
				{
					count = int.Parse(tokens[2]);
					numbers = ShiftToLeftCountTimes(numbers, count);
				}
				else if (tokens[0] == "shift" && tokens[1] == "right")
				{
					count = int.Parse(tokens[2]);
					numbers = ShiftToRightCountTimes(numbers, count);
				}
			}
			Console.WriteLine(string.Join(" ", numbers));
		}

		private static List<int> ShiftToRightCountTimes(List<int> numbers, int count)
		{
			for (int i = 0; i < count; i++)
			{
				int last = numbers.Last();
				numbers.RemoveAt(numbers.Count - 1);
				numbers.Insert(0, last);
			}
			return numbers;
		}

		private static List<int> ShiftToLeftCountTimes(List<int> numbers, int count)
		{
			for (int i = 0; i < count; i++)
			{
				int first = numbers[0];
				numbers.RemoveAt(0);
				numbers.Add(first);
			}
			return numbers;
		}

		private static List<int> RemoveAtIndex(List<int> numbers, int index)
		{
			numbers.RemoveAt(index);
			return numbers;
		}

		private static List<int> InsertNumber(List<int> numbers, int element, int index)
		{
			numbers.Insert(index, element);
			return numbers;
		}

		private static List<int> AddNumber(List<int> numbers, int element)
		{
			numbers.Add(element);
			return numbers;
		}
	}
}
