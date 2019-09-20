using System;

namespace Replace_Repeating_Chars
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			for (int i = 0; i < input.Length; i++)
			{
				if (i-1 > -1)
				{
					if (input[i] != input[i-1])
					{
						Console.Write(input[i-1]);
					}
				}
			}
			Console.Write(input[input.Length-1]);
		}
	}
}
