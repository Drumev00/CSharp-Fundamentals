using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double flat = 0;
            

            if (month == "May" || month == "October")
            {
                studio = 50;
                flat = 65;
                if (nights > 7 && nights <= 14)
                {
                    studio = studio - (studio * 0.05);
                }
                else if (nights > 14)
                {
                    studio = studio - (studio * 0.30);
                    flat = flat - (flat * 0.10);
                }
                studio = studio * nights;
                flat = flat * nights;
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                flat = 68.70;
                
                if (nights > 14)
                {
                    studio = studio - (studio * 0.20);
                    flat = flat - (flat * 0.10);
                }
                studio = studio * nights;
                flat = flat * nights;
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                flat = 77;
                
                if (nights > 14)
                {
                    flat = flat - (flat * 0.10);
                }
                studio = studio * nights;
                flat = flat * nights;
            }
            Console.WriteLine($"Apartment: {flat:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}
