using System;

namespace Common_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] originalArray = Console.ReadLine().Split();
			string[] comparator = Console.ReadLine().Split();

			for (int i = 0; i < comparator.Length; i++)
			{
				for (int j = 0; j < originalArray.Length; j++)
				{
					if (comparator[i] == originalArray[j])
					{
						Console.Write($"{comparator[i]} ");
					}
				}
			}

		}
	}
}
