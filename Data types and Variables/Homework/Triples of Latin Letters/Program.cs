using System;

namespace Triples_of_Latin_Letters
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (char i = 'a'; i < (char)n + 'a'; i++)
			{
				for (char j = 'a'; j < (char)n + 'a'; j++)
				{
					for (char k = 'a'; k < (char)n+'a'; k++)
					{
						Console.WriteLine($"{i}{j}{k}");
					}
				}
			}
		}
	}
}
