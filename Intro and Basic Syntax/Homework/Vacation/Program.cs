using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string clients = Console.ReadLine();
            string dayFromTheWeek = Console.ReadLine();

            double price = 0;


            if (clients == "Students")
            {
                if (dayFromTheWeek == "Friday")
                {
                    price = people * 8.45;
                }
                else if (dayFromTheWeek == "Saturday")
                {
                    price = people * 9.80;
                }
                else if (dayFromTheWeek == "Sunday")
                {
                    price = people * 10.46;
                }
                if (people >= 30)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (clients == "Business")
            {
                if (people >= 100)
                {
                    people = people - 10;
                }
                if (dayFromTheWeek == "Friday")
                {
                    price = people * 10.90;
                }
                else if (dayFromTheWeek == "Saturday")
                {
                    price = people * 15.60;
                }
                else if (dayFromTheWeek == "Sunday")
                {
                    price = people * 16;
                }
            }
            else if (clients == "Regular")
            {
                if (dayFromTheWeek == "Friday")
                {
                    price = people * 15;
                }
                else if (dayFromTheWeek == "Saturday")
                {
                    price = people * 20;
                }
                else if (dayFromTheWeek == "Sunday")
                {
                    price = people * 22.50;
                }
                if (people >= 10 && people <= 20)
                {
                    price = price - (price * 0.05);
                }
            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
