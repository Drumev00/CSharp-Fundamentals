using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> inputData = Console.ReadLine().Split(", ").ToList();
			Articles currentArticle = new Articles();
			currentArticle.Title = inputData[0];
			currentArticle.Content = inputData[1];
			currentArticle.Author = inputData[2];

			int n = int.Parse(Console.ReadLine());
			string command = Console.ReadLine();
			List<string> tokens = command.Split().ToList();
			while (n > 0)
			{
				if (tokens[0] == "Edit:")
				{
					tokens.RemoveAt(0);
					currentArticle.Content = currentArticle.Edit(currentArticle, tokens);
				}
				else if (tokens[0] == "ChangeAuthor:")
				{
					tokens.RemoveAt(0);
					currentArticle.Author = currentArticle.ChangeAuthor(currentArticle, tokens);
				}
				else if (tokens[0] == "Rename:")
				{
					tokens.RemoveAt(0);
					currentArticle.Title = currentArticle.NewTitle(currentArticle, tokens);
				}
				inputData[0] = currentArticle.Title;
				inputData[1] = currentArticle.Content;
				inputData[2] = currentArticle.Author;
				n--;
				if (n >= 1)
				{
					command = Console.ReadLine();
					tokens = command.Split().ToList();
				}
			}
			Console.Write($"{inputData[0]} - {inputData[1]}: {inputData[2]}");
		}
	}
	class Articles
	{
		public string Title;
		public string Content;
		public string Author;
		public string Edit(Articles currentArticle, List<string> tokens)
		{
			Content = string.Join(" ", tokens);
			return Content;
		}
		public string ChangeAuthor(Articles currentArticle, List<string> tokens)
		{
			Author = string.Join(" ", tokens);
			return Author;
		}
		public string NewTitle(Articles currentArticle, List<string> tokens)
		{
			Title = string.Join(" ", tokens);
			return Title;
		}
	}
}
