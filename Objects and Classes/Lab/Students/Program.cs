using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			List<string> dataSplit = command.Split().ToList();
			List<Student> studentData = new List<Student>();
			while (command != "end")
			{
				Student singleStudent = new Student();
				singleStudent.FirstName = dataSplit[0];
				singleStudent.LastName = dataSplit[1];
				singleStudent.Age = int.Parse(dataSplit[2]);
				singleStudent.Hometown = dataSplit[3];
				studentData.Add(singleStudent);
				command = Console.ReadLine();
				dataSplit = command.Split().ToList();
			}
			string city = Console.ReadLine();
			foreach (Student student in studentData)
			{
				if (city == student.Hometown)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}
		}
	}
	class Student
	{
		public string FirstName;
		public string LastName;
		public int Age;
		public string Hometown;
	}
}
