using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotation
{
	class Program
	{
		static void Main(string[] args)
		{
			short[] myArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
			byte rotations = byte.Parse(Console.ReadLine());

			for (int i = 0; i < rotations; i++)
			{
				short[] rotatingArray = new short[myArray.Length];
				for (int j = 0; j < rotatingArray.Length; j++)
				{
					if (j + 1 > rotatingArray.Length - 1)
					{
						rotatingArray[j] = myArray[0];
					}
					else
					{
						rotatingArray[j] = myArray[j + 1];
					}
				}
				myArray = rotatingArray;
			}
			foreach (var number in myArray)
			{
				Console.Write(number + " ");
			}
		}
	}
}
