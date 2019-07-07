using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			short[] myArray = Console.ReadLine().Split().Select(short.Parse).ToArray();

			for (int i = 0; i < myArray.Length - 1; i++)
			{
				if (myArray[i] > myArray[i + 1])
				{
					Console.Write($"{myArray[i]} ");
				}
			}
			Console.Write($"{myArray[myArray.Length-1]}");
		}
	}
}
