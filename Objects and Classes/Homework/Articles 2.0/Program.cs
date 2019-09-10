using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Article> articles = new List<Article>();
			Article singleArticle = new Article();
			for (int i = 0; i < n; i++)
			{
				string inputData = Console.ReadLine();
				List<string> tokens = inputData.Split(", ").ToList();
				singleArticle = new Article();
				singleArticle.Title = tokens[0];
				singleArticle.Content = tokens[1];
				singleArticle.Author = tokens[2];
				articles.Add(singleArticle);
			}
			string orderBy = Console.ReadLine();

			if (orderBy == "title")
			{
				var result = articles.OrderBy(a => a.Title);
				foreach (var article in result)
				{
					Console.Write($"{article.Title} - {article.Content}: {article.Author}");
					Console.WriteLine();
				}
			}
			else if (orderBy == "content")
			{
				var result = articles.OrderBy(a => a.Content);

				foreach (var article in result)
				{
					Console.Write($"{article.Title} - {article.Content}: {article.Author}");
					Console.WriteLine();
				}
			}
			else if (orderBy == "author")
			{
				var result = articles.OrderBy(a => a.Author);

				foreach (var article in result)
				{
					Console.Write($"{article.Title} - {article.Content}: {article.Author}");
					Console.WriteLine();
				}
			}
		}
	}
	class Article
	{
		public string Title;
		public string Content;
		public string Author;
	}
}
