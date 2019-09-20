using System;

namespace Extract_File
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int index = input.LastIndexOf("\\");
			string file = string.Empty;
			for (int i = index+1; i < input.Length ; i++)
			{
				file += string.Concat(input[i]);
			}
			string[] splitedFile = file.Split('.');
			Console.WriteLine($"File name: {splitedFile[0]}");
			Console.WriteLine($"File extension: {splitedFile[1]}");

		}
	}
}
