using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_Zag_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			byte n = byte.Parse(Console.ReadLine());

			short[] firstArray = new short[n];
			short[] secondArray = new short[n];

			for (byte i = 0; i < n; i++)
			{
				short[] inputData = Console.ReadLine().Split().Select(short.Parse).ToArray();
				if (i % 2 == 0)
				{
					firstArray[i] += inputData[0];
					secondArray[i] += inputData[1];
				}
				else
				{
					secondArray[i] += inputData[0];
					firstArray[i] += inputData[1];
				}
			}
			for (int i = 0; i < firstArray.Length; i++)
			{
				Console.Write($"{firstArray[i]} ");
			}
			Console.WriteLine();
			for (int i = 0; i < secondArray.Length; i++)
			{
				Console.Write($"{secondArray[i]} ");
			}

		}
	}
}
