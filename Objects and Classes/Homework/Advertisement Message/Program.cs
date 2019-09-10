using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<string> phrases = new List<string>();
			Phrases singlePhrase = new Phrases();

			List<string> events = new List<string>();
			Events singleEvent = new Events();

			List<string> authors = new List<string>();
			Authors singleAuthor = new Authors();

			List<string> cities = new List<string>();
			Cities singleCity = new Cities();
			
			
			
			for (int i = 0; i < n; i++)
			{
				int phraseNumber = GetPhraseIndex(phrases, singlePhrase);
				Console.Write($"{phrases[phraseNumber].Trim()} ");
				int eventNumber = GetEventIndex(events, singleEvent);
				Console.Write($"{events[eventNumber].Trim()} ");
				int authorNumber = GetAuthorIndex(authors, singleAuthor);
				Console.Write($"{authors[authorNumber].Trim()} - ");
				int cityNumber = GetCityIndex(cities, singleCity);
				Console.WriteLine(cities[cityNumber]);
			}
		}

		private static int GetCityIndex(List<string> cities, Cities singleCity)
		{
			cities.Add(singleCity.city1);
			cities.Add(singleCity.city2);
			cities.Add(singleCity.city3);
			cities.Add(singleCity.city4);
			cities.Add(singleCity.city5);
			int cityNumber = rnd.Next(0, cities.Count);
			return cityNumber;
		}

		private static int GetAuthorIndex(List<string> authors, Authors singleAuthor)
		{
			authors.Add(singleAuthor.author1);
			authors.Add(singleAuthor.author2);
			authors.Add(singleAuthor.author3);
			authors.Add(singleAuthor.author4);
			authors.Add(singleAuthor.author5);
			authors.Add(singleAuthor.author6);
			authors.Add(singleAuthor.author7);
			authors.Add(singleAuthor.author8);
			int authorNumber = rnd.Next(0, authors.Count);
			return authorNumber;
		}

		private static int GetEventIndex(List<string> events, Events singleEvent)
		{
			events.Add(singleEvent.event1);
			events.Add(singleEvent.event2);
			events.Add(singleEvent.event3);
			events.Add(singleEvent.event4);
			events.Add(singleEvent.event5);
			events.Add(singleEvent.event6);
			int eventNumber = rnd.Next(0, events.Count);
			return eventNumber;
		}

		private static int GetPhraseIndex(List<string> phrases, Phrases singlePhrase)
		{
			phrases.Add(singlePhrase.phrase1);
			phrases.Add(singlePhrase.phrase2);
			phrases.Add(singlePhrase.phrase3);
			phrases.Add(singlePhrase.phrase4);
			phrases.Add(singlePhrase.phrase5);
			phrases.Add(singlePhrase.phrase6);
			int phraseNumber = rnd.Next(0, phrases.Count);
			return phraseNumber;
		}
	}
	class Cities
	{
		public string city1;
		public string city2;
		public string city3;
		public string city4;
		public string city5;
		public Cities()
		{
			city1 = "Burgas";
			city2 = "Sofia";
			city3 = "Plovdiv";
			city4 = "Varna";
			city5 = "Ruse";
		}
	}
	class Authors
	{
		public string author1;
		public string author2;
		public string author3;
		public string author4;
		public string author5;
		public string author6;
		public string author7;
		public string author8;
		public Authors()
		{
			author1 = "Diana";
			author2 = "Petya";
			author3 = "Stella";
			author4 = "Elena";
			author5 = "Katya";
			author6 = "Iva";
			author7 = "Annie";
			author8 = "Eva";
		}

	}
	class Events
	{
		public string event1;
		public string event2;
		public string event3;
		public string event4;
		public string event5;
		public string event6;
		public Events()
		{
			event1 = "Now I feel good.";
			event2 = "I have succeeded with this product.";
			event3 = "Makes Miracles. I am happy of the results!";
			event4 = "I cannot believe but now I feel awesome.";
			event5 = "Try it yourself, I am very satisfied.";
			event6 = "I feel great!.";
		}
	}
	class Phrases
	{
		public string phrase1;
		public string phrase2;
		public string phrase3;
		public string phrase4;
		public string phrase5;
		public string phrase6;
		public Phrases()
		{
			phrase1 = "Excellent product.";
			phrase2 = "Such a great product.";
			phrase3 = "I always use that product.";
			phrase4 = "Best product of its category.";
			phrase5 = "Exceptional product.";
			phrase6 = "I can't live without this product.";
		}
	}
}
