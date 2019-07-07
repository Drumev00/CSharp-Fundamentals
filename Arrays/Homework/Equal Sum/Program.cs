using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			short[] myArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
			short leftSum = 0;
			short rightSum = 0;
			bool isValid = true;

			for (int i = 0; i < myArray.Length; i++)
			{
				for (int k = i; k > 0; k--)
				{
					leftSum += myArray[k-1];
				}
				for (int j = myArray.Length - 1; j > i; j--)
				{
					rightSum += myArray[j];
					
				}
				if (leftSum == rightSum)
				{
					Console.WriteLine(i);
					isValid = false;
					break;
				}
				else
				{
					leftSum = 0;
					rightSum = 0;
				}
			}
			if (isValid)
			{
				Console.WriteLine("no");
			}
		}
	}
}
