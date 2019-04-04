using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    price = budget * 0.30;
                }
                else if (season == "winter")
                {
                    price = budget * 0.70;
                }

            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");


                if (season == "summer")
                {
                    price = budget * 0.40;
                }
                else if (season == "winter")
                {
                    price = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");

                price = budget * 0.90;
            }

            if (budget > 1000)
            {
                Console.WriteLine($"Hotel - {price:F2}");
            }
            else if (season == "summer")
            {
                Console.WriteLine($"Camp - {price:F2}");
            }
            else if (season == "winter")
            {
                Console.WriteLine($"Hotel - {price:F2}");
            }
        }
    }
}
