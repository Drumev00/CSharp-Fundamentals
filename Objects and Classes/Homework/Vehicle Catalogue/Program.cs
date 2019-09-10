using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			List<string> tokens = command.Split().ToList();

			Car singleCar = new Car();
			List<Car> cars = new List<Car>();
			decimal carsTotalHorsePower = 0;

			Truck singleTruck = new Truck();
			List<Truck> trucks = new List<Truck>();
			decimal trucksTotalHorsePower = 0;
			while (command != "End")
			{
				if (tokens[0] == "car")
				{
					singleCar = new Car();
					singleCar.Type = tokens[0];
					singleCar.Model = tokens[1];
					singleCar.Color = tokens[2];
					singleCar.HorsePower = int.Parse(tokens[3]);
					carsTotalHorsePower += singleCar.HorsePower;
					cars.Add(singleCar);
				}
				else
				{
					singleTruck = new Truck();
					singleTruck.Type = tokens[0];
					singleTruck.Model = tokens[1];
					singleTruck.Color = tokens[2];
					singleTruck.HorsePower = int.Parse(tokens[3]);
					trucksTotalHorsePower += singleTruck.HorsePower;
					trucks.Add(singleTruck);
				}
				command = Console.ReadLine();
				tokens = command.Split().ToList();
			}
			while (command != "Close the Catalogue")
			{
				command = Console.ReadLine();
				foreach (var car in cars)
				{
					if (car.Model == command)
					{
						Console.WriteLine($"Type: Car");
						Console.WriteLine($"Model: {car.Model}");
						Console.WriteLine($"Color: {car.Color}");
						Console.WriteLine($"Horsepower: {car.HorsePower}");
					}
				}
				foreach (var truck in trucks)
				{
					if (truck.Model == command)
					{
						Console.WriteLine($"Type: Truck");
						Console.WriteLine($"Model: {truck.Model}");
						Console.WriteLine($"Color: {truck.Color}");
						Console.WriteLine($"Horsepower: {truck.HorsePower}");
					}
				}
			}
			decimal carsAverage = 0.0M;
			decimal trucksAverage = 0.0M;
			if (cars.Count > 0)
			{
				carsAverage = carsTotalHorsePower / cars.Count;
				Console.WriteLine($"Cars have average horsepower of: {carsAverage:F2}.");
			}
			else
			{
				Console.WriteLine($"Cars have average horsepower of: {carsAverage:F2}.");
			}
			if ( trucks.Count > 0)
			{
				trucksAverage = trucksTotalHorsePower / trucks.Count;
				Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:F2}.");
			}
			else
			{
				Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:F2}.");
			}
		} 
	}
	class Car
	{
		public string Type;
		public string Model;
		public string Color;
		public int HorsePower;
	}
	class Truck
	{
		public string Type;
		public string Model;
		public string Color;
		public int HorsePower;
	}

}
