using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine().ToLower();
			string[] tokens = command.Split();
			int element = 0;
			int index = 0;
			while(command != "end")
			{
				if (tokens[0] == "delete")
				{
					element = int.Parse(tokens[1]);
					numbers = DeleteAnElement(numbers, element);
				}
				else if (tokens[0] == "insert")
				{
					element = int.Parse(tokens[1]);
					index = int.Parse(tokens[2]);
					numbers.Insert(index, element);
				}
				command = Console.ReadLine().ToLower();
				tokens = command.Split();
			}
			Console.WriteLine(string.Join(" ", numbers));
		}

		private static List<int> DeleteAnElement(List<int> numbers, int element)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == element)
				{
					numbers.Remove(element);
					i--;
				}
			}
			return numbers;
		}
	}
}
