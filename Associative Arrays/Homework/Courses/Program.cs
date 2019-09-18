using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
	class Program
	{
		static void Main(string[] args)
		{
			var courses = new Dictionary<string, List<string>>();
			string command = Console.ReadLine();
			string[] tokens = command.Split(" : ");

			while (command != "end")
			{
				if (!courses.ContainsKey(tokens[0]))
				{
					courses.Add(tokens[0], new List<string>());
				}
				courses[tokens[0]].Add(tokens[1]);


				command = Console.ReadLine();
				tokens = command.Split(" : ");
			}
			foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
				foreach (var item in kvp.Value.OrderBy(x => x))
				{
					Console.WriteLine($"-- {item}");
				}
			}
		}
	}
}
