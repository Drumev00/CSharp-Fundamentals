using System;
using System.Collections.Generic;
using System.Linq;

namespace Last_Stop
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> paintingNumber = Console.ReadLine().Split().Select(int.Parse).ToList();
			string command = Console.ReadLine();
			string[] tokens = command.Split();

			int number = 0;
			int replacement = 0;

			while (command != "END")
			{
				if (tokens[0] == "Change")
				{
					number = int.Parse(tokens[1]);
					replacement = int.Parse(tokens[2]);
					if (paintingNumber.Contains(number))
					{
						paintingNumber = ChangeNumber(paintingNumber, number, replacement);
					}
				}
				else if (tokens[0] == "Hide")
				{
					number = int.Parse(tokens[1]);
					if (paintingNumber.Contains(number))
					{
						paintingNumber = HideNumber(paintingNumber, number);
					}
				}
				else if (tokens[0] == "Switch")
				{
					number = int.Parse(tokens[1]);
					replacement = int.Parse(tokens[2]);
					if (paintingNumber.Contains(number) && paintingNumber.Contains(replacement))
					{
						paintingNumber = SwitchNumbers(paintingNumber, number, replacement);
					}
				}
				else if (tokens[0] == "Insert")
				{
					number = int.Parse(tokens[1]);
					replacement = int.Parse(tokens[2]);
					if (number+1 < paintingNumber.Count)
					{
						paintingNumber = InsertNumber(paintingNumber, number, replacement);
					}
				}
				else if (tokens[0] == "Reverse")
				{
					paintingNumber.Reverse();
				}
				command = Console.ReadLine();
				tokens = command.Split();
			}
			Console.WriteLine(string.Join(" ", paintingNumber));
		}

		private static List<int> InsertNumber(List<int> paintingNumber, int number, int replacement)
		{
			paintingNumber.Insert(number + 1, replacement);
			return paintingNumber;
		}

		private static List<int> SwitchNumbers(List<int> paintingNumber, int number, int replacement)
		{
			
			int indexOfPaintNumber = paintingNumber.IndexOf(number);
			int indexOfSwitchingNumber = paintingNumber.IndexOf(replacement);
			int temp = paintingNumber[indexOfPaintNumber];

			paintingNumber[indexOfPaintNumber] = paintingNumber[indexOfSwitchingNumber];
			paintingNumber[indexOfSwitchingNumber] = temp;
			return paintingNumber;
		}

		private static List<int> HideNumber(List<int> paintingNumber, int number)
		{
			paintingNumber.Remove(number);
			return paintingNumber;
		}

		private static List<int> ChangeNumber(List<int> paintingNumber, int number, int replacement)
		{
			int indexOf = paintingNumber.IndexOf(number);
			paintingNumber[indexOf] = replacement;
			return paintingNumber;
		}
	}
}
