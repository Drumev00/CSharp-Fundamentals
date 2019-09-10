using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			//John Smith 15 Sofia
			//Peter Ivanov 14 Plovdiv
			//Peter Ivanov 25 Plovdiv
			//Linda Bridge 16 Sofia
			//Linda Bridge 27 Sofia
			//Simon Stone 12 Varna
			//end

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
			for (int i = 0; i < studentData.Count; i++)
			{
				for (int j = 0; j < studentData.Count; j++)
				{
					if (studentData[i].FirstName == studentData[j].FirstName && studentData[i].LastName == studentData[j].LastName && i != j)
					{
						studentData[i].Age = studentData[j].Age;
						studentData.RemoveAt(j);
					}
				}
			}
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
