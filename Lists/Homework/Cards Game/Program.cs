using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstPlayersHand = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondPlayersHand = Console.ReadLine().Split().Select(int.Parse).ToList();

			for (int i = 0; i < firstPlayersHand.Count; i++)
			{
				if (secondPlayersHand.Count == 0 || firstPlayersHand.Count == 0)
				{
					break;
				}
				if (firstPlayersHand[i] > secondPlayersHand[i])
				{
					firstPlayersHand.Add(secondPlayersHand[i]);
					firstPlayersHand.Insert(firstPlayersHand.Count - 1, firstPlayersHand[i]);
					firstPlayersHand.RemoveAt(i);
					secondPlayersHand.RemoveAt(i);
					i--;
				}
				else if (firstPlayersHand[i] < secondPlayersHand[i])
				{
					secondPlayersHand.Add(firstPlayersHand[i]);
					secondPlayersHand.Insert(secondPlayersHand.Count - 1, secondPlayersHand[i]);
					secondPlayersHand.RemoveAt(i);
					firstPlayersHand.RemoveAt(i);
					i--;
				}
				else if (firstPlayersHand[i] == secondPlayersHand[i])
				{
					firstPlayersHand.RemoveAt(i);
					secondPlayersHand.RemoveAt(i);
					i--;
				}
			}
			if (firstPlayersHand.Sum() > secondPlayersHand.Sum())
			{
				Console.WriteLine($"First player wins! Sum: {firstPlayersHand.Sum()}");
			}
			else
			{
				Console.WriteLine($"Second player wins! Sum: {secondPlayersHand.Sum()}");
			}
			
			
		}
	}
}
