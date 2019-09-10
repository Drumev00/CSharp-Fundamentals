using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string studentData = Console.ReadLine();
			List<string> tokens = studentData.Split().ToList();
			Student singleStudent = new Student();
			List<Student> students = new List<Student>();
			while (n > 0)
			{
				singleStudent = new Student();
				singleStudent.FirstName = tokens[0];
				singleStudent.LastName = tokens[1];
				singleStudent.Grade = decimal.Parse(tokens[2]);
				students.Add(singleStudent);
				n--;
				if (n >= 1)
				{
					studentData = Console.ReadLine();
					tokens = studentData.Split().ToList();
				}
			}
			var result = students.OrderByDescending(a => a.Grade);
			foreach (var student in result)
			{
				Console.Write($"{student.FirstName} {student.LastName}: {student.Grade}");
				Console.WriteLine();
			}
		}
	}
	class Student
	{
		public string FirstName;
		public string LastName;
		public decimal Grade;
	}
}
