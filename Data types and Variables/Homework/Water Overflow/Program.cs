using System;

namespace Water_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			byte n = byte.Parse(Console.ReadLine());
			short sum = 0;

			for (byte i = 1; i <= n; i++)
			{
				short liters = short.Parse(Console.ReadLine());
				sum += liters;
				if (sum > 255)
				{
					Console.WriteLine("Insufficient capacity!");
					sum -= liters;
				}
			}
			Console.WriteLine(sum);



			

		}
	}
}
