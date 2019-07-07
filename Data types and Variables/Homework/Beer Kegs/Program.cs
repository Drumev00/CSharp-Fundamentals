using System;

namespace Beer_Kegs
{
	class Program
	{
		static void Main(string[] args)
		{
			byte n = byte.Parse(Console.ReadLine());
			string biggestKegModel = string.Empty;
			double max = double.MinValue;

			for (byte i = 1; i <= n; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());

				double volume = Math.PI * Math.Pow(radius, 2) * height;
				
				if (max < volume)
				{
					biggestKegModel = model;
					max = volume;
				}
			}
			Console.WriteLine(biggestKegModel);
			


		}
	}
}
