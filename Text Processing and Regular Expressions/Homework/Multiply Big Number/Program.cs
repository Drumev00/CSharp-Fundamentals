using System;
using System.Numerics;

namespace Multiply_Big_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger number = BigInteger.Parse(Console.ReadLine());
			byte multiplier = byte.Parse(Console.ReadLine());
			BigInteger result = number * multiplier;
			Console.WriteLine(result);
		}
	}
}
