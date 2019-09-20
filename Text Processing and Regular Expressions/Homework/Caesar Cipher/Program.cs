using System;

namespace Caesar_Cipher
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string encryptedVersion = string.Empty;
			for (int i = 0; i < input.Length; i++)
			{
				char currentChar = input[i];
				encryptedVersion += (char)(currentChar + 3);
			}
			Console.WriteLine(encryptedVersion);
		}
	}
}
