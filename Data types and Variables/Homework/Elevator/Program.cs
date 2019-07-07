using System;

namespace Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int people = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());

			int courses = people / capacity;
			int potentiallyMoreCoursesAndPeople = people % capacity;
			if (potentiallyMoreCoursesAndPeople != 0)
			{
				courses++;
			}
			Console.WriteLine(courses);
		}
	}
}
