using System;

namespace Password_Validator
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();
			bool borderIsValid = PasswordBorder(password);
			bool contentIsValid = PasswordContent(password);
			bool hasDigits = PasswordHasDigits(password);
			if (hasDigits && contentIsValid && borderIsValid)
			{
				Console.WriteLine("Password is valid");
			}
			
		}

		static bool PasswordHasDigits(string password)
		{
			int count = 0;
			
			foreach (char c in password)
			{
				if (char.IsDigit(c)) count++;
			}
			if (count < 2)
			{
				Console.WriteLine("Password must have at least 2 digits");
				return false;
			}
			else
			{
				return true;
			}
			
		}

		static bool PasswordContent(string password)
		{
			bool hasSymbol = false;
			foreach (char c in password)
			{
				if (!char.IsLetterOrDigit(c)) hasSymbol = true;
			}
			if (hasSymbol)
			{
				Console.WriteLine("Password must consist only of letters and digits");
				return false;
			}
			else
			{
				return true;
			}
		}

		static bool PasswordBorder(string password)
		{
			
			if (password.Length - 1 < 5 || password.Length - 1 > 9)
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
				return false;
			}
			else
			{
				return true;
			}
			
		}
	}
}
