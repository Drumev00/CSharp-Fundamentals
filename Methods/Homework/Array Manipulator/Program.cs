using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			 int[] numArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			string input = Console.ReadLine();
			int exchangeIndex = 0;

			while (input != "end")
			{
				string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
				if (tokens[0] == "exchange")
				{
					exchangeIndex = int.Parse(tokens[1]);
					if (exchangeIndex < 0 || exchangeIndex >= numArray.Length)
					{
						Console.WriteLine("Invalid index");
					}
					else
					{
						numArray = ArraySpliter(exchangeIndex, numArray);
					}
				}
				else if (input == "max odd" || input == "max even")
				{
					GetMaxOddOrEvenIndex(numArray, tokens);
				}
				else if (input == "min odd" || input == "min even")
				{
					GetMinOddOrEvenIndex(numArray, tokens);
				}
				else if (tokens[0] == "first" && tokens[2] == "even" || tokens[2] == "odd")
				{
					int countOfNumbers = int.Parse(tokens[1]);
					if (countOfNumbers > numArray.Length)
					{
						Console.WriteLine("Invalid count");
					}
					else
					{
						PrintFirstEvenOrOddNumbers(countOfNumbers, numArray, tokens);
					}
				}
				else if (tokens[0] == "last" && tokens[2] == "even" || tokens[2] == "odd")
				{
					int countOfNumbers = int.Parse(tokens[1]);
					if (countOfNumbers > numArray.Length)
					{
						Console.WriteLine("Invalid count");
					}
					else
					{
						PrintLastEvenOrOddNumbers(countOfNumbers, numArray, tokens);
					}
				}
				input = Console.ReadLine();
			}
			Console.WriteLine($"[{string.Join(", ", numArray)}]");
		}

		private static void PrintLastEvenOrOddNumbers(int countOfNumbers, int[] numArray, string[] tokens)
		{
			List<int> lastEvenCount = new List<int>();
			List<int> lastOddCount = new List<int>();
			int count = 0;
			if (tokens[2] == "even")
			{
				for (int i = numArray.Length - 1; i >= 0; i--)
				{
					if (numArray[i] % 2 == 0)
					{
						if (count >= countOfNumbers)
						{
							break;
						}
						lastEvenCount.Add(numArray[i]);
						count++;
					}
				}
				lastEvenCount.Reverse();
				Console.WriteLine($"[{string.Join(", ", lastEvenCount)}]");
			}
			else if (tokens[2] == "odd")
			{
				for (int i = numArray.Length - 1; i >= 0; i--)
				{
					if (numArray[i] % 2 != 0)
					{
						if (count >= countOfNumbers)
						{
							break;
						}
						lastOddCount.Add(numArray[i]);
						count++;
					}
				}
				lastOddCount.Reverse();
				Console.WriteLine($"[{string.Join(", ", lastOddCount)}]");
			}
		}

		private static void PrintFirstEvenOrOddNumbers(int countOfNumbers, int[] numArray, string[] tokens)
		{
			List<int> firstEvenCount = new List<int>();
			List<int> firstOddCount = new List<int>();
			int count = 0;
			if (tokens[2] == "even")
			{
				for (int i = 0; i < numArray.Length; i++)
				{
					if (numArray[i] % 2 == 0)
					{
						if (count >= countOfNumbers)
						{
							break;
						}
						firstEvenCount.Add(numArray[i]);
						count++;
					}
				}
				Console.WriteLine($"[{string.Join(", ", firstEvenCount)}]");
			}
			else if (tokens[2] == "odd")
			{
				for (int i = 0; i < numArray.Length; i++)
				{
					if (numArray[i] % 2 != 0)
					{
						if (count >= countOfNumbers)
						{
							break;
						}
						firstOddCount.Add(numArray[i]);
						count++;
					}
				}
				Console.WriteLine($"[{string.Join(", ", firstOddCount)}]");
			}
		}

		private static void GetMinOddOrEvenIndex(int[] numArray, string[] tokens)
		{
			int minEvenPosition = int.MaxValue;
			int minEvenNumber = int.MaxValue;
			int minOddPosition = int.MaxValue;
			int minOddNumber = int.MaxValue;
			if (tokens[1] == "odd")
			{
				for (int i = 0; i < numArray.Length; i++)
				{
					if (numArray[i] % 2 != 0 && minOddNumber >= numArray[i])
					{
						minOddNumber = numArray[i];
						minOddPosition = i;
					}
				}
				if (minOddPosition == int.MaxValue)
				{
					Console.WriteLine("No matches");
				}
				else
				{
					Console.WriteLine(minOddPosition);
				}
			}
			else if (tokens[1] == "even")
			{
				for (int i = 0; i < numArray.Length; i++)
				{
					if (numArray[i] % 2 == 0 && minEvenNumber >= numArray[i])
					{
						minEvenNumber = numArray[i];
						minEvenPosition = i;
					}
				}
				if (minEvenPosition == int.MaxValue)
				{
					Console.WriteLine("No matches");
				}
				else
				{
					Console.WriteLine(minEvenPosition);
				}
			}
		}

		private static void GetMaxOddOrEvenIndex(int[] numArray, string[] tokens)
		{
			int maxEvenPosition = int.MinValue;
			int maxEvenNumber = int.MinValue;
			int maxOddPosition = int.MinValue;
			int maxOddNumber = int.MinValue;
			if (tokens[1] == "odd")
			{
				for (int i = 0; i < numArray.Length; i++)
				{
					if (numArray[i] % 2 != 0 && maxOddNumber <= numArray[i])
					{
						maxOddNumber = numArray[i];
						maxOddPosition = i;
					}
				}
				if (maxOddPosition == int.MinValue)
				{
					Console.WriteLine("No matches");
				}
				else
				{
					Console.WriteLine(maxOddPosition);
				}
			}
			else if (tokens[1] == "even")
			{
				for (int i = 0; i < numArray.Length; i++)
				{
					if (numArray[i] % 2 == 0 && maxEvenNumber <= numArray[i])
					{
						maxEvenNumber = numArray[i];
						maxEvenPosition = i;
					}
				}
				if (maxEvenPosition == int.MinValue)
				{
					Console.WriteLine("No matches");
				}
				else
				{
					Console.WriteLine(maxEvenPosition);
				}
			}
		}

		private static int[] ArraySpliter(int exchangeIndex, int[] numArray)
		{
			for (int i = 0; i <= exchangeIndex; i++)
			{
				int[] rotatingArray = new int[numArray.Length];
				for (int j = 0; j < rotatingArray.Length; j++)
				{
					if (j + 1 > rotatingArray.Length - 1)
					{
						rotatingArray[j] = numArray[0];
					}
					else
					{
						rotatingArray[j] = numArray[j + 1];
					}
				}
				numArray = rotatingArray;
			}
			return numArray;
		}

	}
}
