using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
	class Program
	{
		static void Main(string[] args)
		{
			var users = new Dictionary<string, string>();
			int n = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			string[] tokens = command.Split();
			while (n > 0)
			{
				if (tokens[0] == "register")
				{
					if (users.ContainsKey(tokens[1]))
					{
						Console.WriteLine($"ERROR: already registered with plate number {users[tokens[1]]}");
					}
					else
					{
						users.Add(tokens[1], tokens[2]);
						Console.WriteLine($"{tokens[1]} registered {users[tokens[1]]} successfully");
					}
				}
				else if (tokens[0] == "unregister")
				{
					if (!users.ContainsKey(tokens[1]))
					{
						Console.WriteLine($"ERROR: user {tokens[1]} not found");
					}
					else
					{
						Console.WriteLine($"{tokens[1]} unregistered successfully");
						users.Remove(tokens[1]);
					}
				}
				n--;
				if (n == 0)
					break;
				command = Console.ReadLine();
				tokens = command.Split();
			}
			foreach (var item in users)
			{
				Console.WriteLine($"{item.Key} => {item.Value}");
			}
		}
	}
}
