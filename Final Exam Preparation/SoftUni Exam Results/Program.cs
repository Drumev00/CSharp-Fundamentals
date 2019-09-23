using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
	class Program
	{
		static void Main(string[] args)
		{
			var usersAndPoints = new Dictionary<string, int>();
			var submissions = new Dictionary<string, int>();
			string input = Console.ReadLine();
			string[] tokens = input.Split("-");

			while (input != "exam finished")
			{
				string name = tokens[0];
				string technology = tokens[1];
				int points = 0;

				if (!usersAndPoints.ContainsKey(name))
				{
					points = int.Parse(tokens[2]);
					usersAndPoints[name] = points;
				}
				else if (tokens[1] == "banned")
				{
					usersAndPoints.Remove(name);
				}
				else if (usersAndPoints.ContainsKey(name))
				{
					if (usersAndPoints[name] < int.Parse(tokens[2]))
					{
						usersAndPoints[name] = int.Parse(tokens[2]);
					}
				}
				if (!submissions.ContainsKey(technology) && technology != "banned")
				{
					submissions[technology] = 1;
				}
				else if (submissions.ContainsKey(technology))
				{
					submissions[technology]++;
				}
				input = Console.ReadLine();
				tokens = input.Split("-");
			}
			Console.WriteLine("Results:");
			foreach (var kvp in usersAndPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{kvp.Key} | {kvp.Value}");
			}
			Console.WriteLine("Submissions:");
			foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{kvp.Key} - {kvp.Value}");
			}
		}
	}
}
