using System;

namespace Palindrome_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			CheksIfTheNumberIsPalindrome(text);
		}

		static void CheksIfTheNumberIsPalindrome(string text)
		{
			while (text != "END")
			{
				char[] charArray = text.ToCharArray();
				string reversed = string.Empty;
				for (int i = charArray.Length - 1; i > -1; i--)
				{
					reversed += charArray[i];
				}
				if (reversed == text)
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}
				text = Console.ReadLine();
			}
			
		}
	}
}
