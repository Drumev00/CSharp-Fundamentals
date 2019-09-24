using System;

namespace Deciphering
{
	class Program
	{
		static void Main(string[] args)
		{
			string script = Console.ReadLine();
			bool isValid = false;

			for (int i = 0; i < script.Length; i++)
			{
				if (script[i] == '{' || script[i] == '}' || script[i] == '|' || script[i] == '#' || script[i] >= 100 && script[i] <= 122)
				{
					isValid = true;
				}
				else
				{
					Console.WriteLine("This is not the book you are looking for.");
					isValid = false;
					break;
				}
			}
			if (isValid)
			{
				string decodedScript = string.Empty;
				for (int i = 0; i < script.Length; i++)
				{
					decodedScript += (char)(script[i] - 3);
				}
				string stringToReplace = Console.ReadLine();
				string[] tokens = stringToReplace.Split();
				for (int i = 0; i < decodedScript.Length; i++)
				{
					if (decodedScript.Contains(tokens[0]))
					{
						decodedScript = decodedScript.Replace(tokens[0], tokens[1]);
					}
				}
				Console.WriteLine(decodedScript);
			}
		}
	}
}
