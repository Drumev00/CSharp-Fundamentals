using System;

namespace Hogswatch
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int initialPresents = int.Parse(Console.ReadLine());
			int startingPresents = initialPresents;
			int count = 0;
			bool heWentBack = false;
			int additional = 0;

			for (int i = 1; i <= n; i++)
			{
				int amountOfSocks = int.Parse(Console.ReadLine());
				initialPresents -= amountOfSocks;
				if (initialPresents < 0)
				{
					heWentBack = true;
					count++;
					int neededPresets = Math.Abs(initialPresents);
					int remainedHomes = n - i;
					initialPresents = (startingPresents / i) * remainedHomes + neededPresets;
					additional += initialPresents;
					initialPresents -= neededPresets;
				}
			}
			if (heWentBack)
			{
				Console.WriteLine($"{count}");
				Console.WriteLine($"{additional}");
			}
			else
			{
				Console.WriteLine(initialPresents);
			}
			
		}
	}
}
