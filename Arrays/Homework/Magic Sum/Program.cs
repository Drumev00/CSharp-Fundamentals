using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			short[] myArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
			byte sum = byte.Parse(Console.ReadLine());

			for (int i = 0; i < myArray.Length; i++)
			{
				for (int j = myArray.Length - 1; j > 0; j--)
				{
					if (myArray[i] + myArray[j] == sum)
					{
						Console.Write($"{myArray[i]} ");
						Console.Write($"{myArray[j]}");
						Console.WriteLine();
					}
				}
			}
		}
	}
}
