using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			List<string> tokens = command.Split().ToList();
			List<Box> boxes = new List<Box>();
			Box singleBox = new Box();

			while (command != "end")
			{
				singleBox = new Box();
				singleBox.SerialNumber = int.Parse(tokens[0]);

				singleBox.ItemName.Name = tokens[1];

				singleBox.ItemQuantity = int.Parse(tokens[2]);


				singleBox.ItemName.Price = decimal.Parse(tokens[3]);
				singleBox.PriceforBox = singleBox.ItemName.Price * singleBox.ItemQuantity;
				boxes.Add(singleBox);
				command = Console.ReadLine();
				tokens = command.Split().ToList();
			}
			var result = boxes.OrderByDescending(a => a.PriceforBox);
			

			foreach (Box box in result)
			{
				Console.WriteLine(box.SerialNumber);
				Console.WriteLine($"-- {box.ItemName.Name} - ${box.ItemName.Price:F2}: {box.ItemQuantity}");
				Console.WriteLine($"-- ${box.PriceforBox:F2}");
			}
		}


	}
	class Item
	{
		public string Name;
		public decimal Price;
	}
	class Box
	{
		public Box()
		{
			ItemName = new Item();
		}
		public int SerialNumber;
		public Item ItemName;
		public int ItemQuantity;
		public decimal PriceforBox;
	}
}
