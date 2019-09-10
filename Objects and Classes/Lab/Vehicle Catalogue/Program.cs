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
			List<string> tokens = command.Split('/').ToList();
			Car singleCar = new Car();
			Truck singleTruck = new Truck();
			List<Car> carsInCatalogue = new List<Car>();
			List<Truck> trucksInCatalogue = new List<Truck>();
			bool areThereTrucks = false;

			while (command != "end")
			{
				if (tokens[0] == "Car")
				{
					singleCar = new Car();
					singleCar.Brand = tokens[1];
					singleCar.Model = tokens[2];
					singleCar.HorsePower = int.Parse(tokens[3]);
					carsInCatalogue.Add(singleCar);
				}
				else
				{
					singleTruck = new Truck();
					singleTruck.Brand = tokens[1];
					singleTruck.Model = tokens[2];
					singleTruck.Weight = int.Parse(tokens[3]);
					trucksInCatalogue.Add(singleTruck);
					areThereTrucks = true;
				}
				command = Console.ReadLine();
				tokens = command.Split('/').ToList();
			}
			var carResult = carsInCatalogue.OrderBy(a => a.Brand);
			carResult.ToList().Reverse();

			var truckResult = trucksInCatalogue.OrderBy(a => a.Brand);
			truckResult.ToList().Reverse();

			Console.WriteLine("Cars:");
			foreach (Car car in carResult)
			{
				Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
			}
			if (areThereTrucks)
			{
				Console.WriteLine("Trucks:");
				foreach (Truck truck in truckResult)
				{
					Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
				}
			}
		}
	}
	class Catalogue
	{
		public List<Truck> trucksInCatalogue;
		public List<Car> carsInCatalogue;
	}

	class Truck
	{
		public string Brand;
		public string Model;
		public int Weight;
	}
	class Car
	{
		public string Brand;
		public string Model;
		public int HorsePower;
	}
}


