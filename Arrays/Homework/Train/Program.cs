using System;

namespace Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] people = new int[n];
			int sum = 0;

			for (int i = 0; i <= n - 1; i++)
			{
				people[i] = int.Parse(Console.ReadLine());
				sum += people[i];
			}

			foreach (var person in people)
			{
				Console.Write(person + " ");
			}
			Console.WriteLine();
			Console.WriteLine(sum);
		}
	}
}
