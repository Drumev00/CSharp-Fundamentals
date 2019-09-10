using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			List<string> tokens = command.Split().ToList();

			Person singlePerson = new Person();
			List<Person> people = new List<Person>();
			while (command != "End")
			{
				singlePerson = new Person();
				singlePerson.Name = tokens[0];
				singlePerson.ID = tokens[1];
				singlePerson.Age = int.Parse(tokens[2]);
				people.Add(singlePerson);
				command = Console.ReadLine();
				tokens = command.Split().ToList();
			}
			var result = people.OrderBy(a => a.Age);
			foreach (var person in result)
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}
		}
	}
	class Person
	{
		public string Name;
		public string ID;
		public int Age;
	}
}
