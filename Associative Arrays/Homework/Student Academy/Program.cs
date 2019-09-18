using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
	class Program
	{
		static void Main(string[] args)
		{
			var studentsGrades = new Dictionary<string, List<double>>();
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string name = Console.ReadLine();
				double grade = double.Parse(Console.ReadLine());
				if (!studentsGrades.ContainsKey(name))
				{
					studentsGrades.Add(name, new List<double>());
				}
				studentsGrades[name].Add(grade);
			}
			foreach (var kvp in studentsGrades.OrderByDescending(x => x.Value.Average()))
			{
				double average = 0.0;
				foreach (var item in kvp.Value)
				{
					average += item;
				}
				average /= kvp.Value.Count;
				if (average >= 4.50)
				{
					Console.WriteLine($"{kvp.Key} -> {average:F2}");
				}
			}
		}
	}
}
