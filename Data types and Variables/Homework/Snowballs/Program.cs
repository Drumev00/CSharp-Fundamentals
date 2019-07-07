using System;

namespace Snowballs
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double max = double.MinValue;
			int biggestSnow = 0;
			int biggestTime = 0;
			int biggestQuality = 0;

			for (int i = 1; i <= n; i++)
			{
				int snowballSnow = int.Parse(Console.ReadLine());
				int snowballTime = int.Parse(Console.ReadLine());
				int snowballQuality = int.Parse(Console.ReadLine());

				double snowballValue = snowballSnow / snowballTime;
				snowballValue = Math.Pow(snowballValue, snowballQuality);
				if (max < snowballValue)
				{
					max = snowballValue;
					biggestSnow = snowballSnow;
					biggestTime = snowballTime;
					biggestQuality = snowballQuality;
				}
			}
			Console.WriteLine($"{biggestSnow} : {biggestTime} = {max} ({biggestQuality})");
		}
	}
}
