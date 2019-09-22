using System;
using System.Linq;

namespace Kamino_Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			int lenght = int.Parse(Console.ReadLine());

			int longestSubSequence = -1;
			int longestSubIndex = -1;
			int longestSubSum = 0;
			int[] sequence = new int[lenght];
			int indexOfLongest = 0;
			int indexOfSequence = 1;

			string input = Console.ReadLine();
			while (input != "Clone them!")
			{
				int[] currentSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				int subSequence = 0;
				int subIndex = -1;
				int subSum = 0;
				int count = 0;
				
				for (int i = 0; i < lenght; i++)
				{
					if (currentSequence[i] == 1)
					{
						count++;
						subSum++;
						if (count > subSequence)
						{
							subSequence = count;
							subIndex = i - count;
						}
					}
					else
					{
						if (count > subSequence)
						{
							subSequence = count;
							subIndex = i - count;
						}
						count = 0;
					}
				}
				if (subSequence > longestSubSequence)
				{
					longestSubSequence = subSequence;
					longestSubIndex = subIndex;
					longestSubSum = subSum;
					sequence = currentSequence;
					indexOfLongest = indexOfSequence;
				}
				else if (subSequence == longestSubSequence && longestSubIndex > subIndex)
				{
					longestSubIndex = subIndex;
					longestSubSum = subSum;
					sequence = currentSequence;
					indexOfLongest = indexOfSequence;
				}
				else if (subSequence == longestSubSequence && subIndex == longestSubIndex && subSum > longestSubSum)
				{
					sequence = currentSequence;
					longestSubSum = subSum;
					indexOfLongest = indexOfSequence;
				}
				indexOfSequence++;
				input = Console.ReadLine();
			}
			Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
			Console.WriteLine(string.Join(" ", sequence));
		}
	}
}
