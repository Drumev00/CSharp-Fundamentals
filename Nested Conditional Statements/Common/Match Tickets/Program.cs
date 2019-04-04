using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            if (ticketType == "VIP")
            {
                ticketPrice = 499.99;

                if (people >= 1 && people <= 4)
                {
                    budget = budget - (budget * 0.75);

                }
                else if (people >= 5 && people <= 9)
                {
                    budget = budget - (budget * 0.60);

                }
                else if (people >= 10 && people <= 24)
                {
                    budget = budget - (budget * 0.50);

                }
                else if (people >= 25 && people <= 49)
                {
                    budget = budget - (budget * 0.40);

                }
                else if (people >= 50)
                {
                    budget = budget - (budget * 0.25);

                }
            }
            else if (ticketType == "Normal")
            {
                ticketPrice = 249.99;

                if (people >= 1 && people <= 4)
                {
                    budget = budget - (budget * 0.75);

                }
                else if (people >= 5 && people <= 9)
                {
                    budget = budget - (budget * 0.60);

                }
                else if (people >= 10 && people <= 24)
                {
                    budget = budget - (budget * 0.50);

                }
                else if (people >= 25 && people <= 49)
                {
                    budget = budget - (budget * 0.40);

                }
                else if (people >= 50)
                {
                    budget = budget - (budget * 0.25);

                }
            }
            if (budget >= ticketPrice * people)
            {
                Console.WriteLine($"Yes! You have {budget - (people * ticketPrice):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs((ticketPrice * people) - budget):F2} leva.");
            }
        }
    }
}
