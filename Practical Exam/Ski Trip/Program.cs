using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacantionDays = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            int overnight = vacantionDays - 1;
            double onePersonRoom = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;
            double price = 0;

            if (vacantionDays < 10)
            {
                if (kindOfRoom == "room for one person" && rating == "positive")
                {
                    price = onePersonRoom * overnight;
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "room for one person" && rating == "negative")
                {
                    price = onePersonRoom * overnight;
                    price = price - (price * 0.10);
                }
                else if (kindOfRoom == "apartment" && rating == "positive")
                {
                    price = apartment * overnight;
                    price = price - (price * 0.30);
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "apartment" && rating == "negative")
                {
                    price = apartment * overnight;
                    price = price - (price * 0.30);
                    price = price - (price * 0.10);
                }
                else if (kindOfRoom == "president apartment" && rating == "positive")
                {
                    price = presidentApartment * overnight;
                    price = price - (price * 0.10);
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "president apartment" && rating == "negative")
                {
                    price = presidentApartment * overnight;
                    price = price - (price * 0.10);
                    price = price - (price * 0.10);
                }
            }
            else if (vacantionDays >= 10 && vacantionDays <= 15)
            {
                if (kindOfRoom == "room for one person" && rating == "positive")
                {
                    price = onePersonRoom * overnight;
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "room for one person" && rating == "negative")
                {
                    price = onePersonRoom * overnight;
                    price = price - (price * 0.10);
                }
                else if (kindOfRoom == "apartment" && rating == "positive")
                {
                    price = apartment * overnight;
                    price = price - (price * 0.35);
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "apartment" && rating == "negative")
                {
                    price = apartment * overnight;
                    price = price - (price * 0.35);
                    price = price - (price * 0.10);
                }
                else if (kindOfRoom == "president apartment" && rating == "positive")
                {
                    price = presidentApartment * overnight;
                    price = price - (price * 0.15);
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "president apartment" && rating == "negative")
                {
                    price = presidentApartment * overnight;
                    price = price - (price * 0.15);
                    price = price - (price * 0.10);
                }
            }
            else if (vacantionDays > 15)
            {
                if (kindOfRoom == "room for one person" && rating == "positive")
                {
                    price = onePersonRoom * overnight;
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "room for one person" && rating == "negative")
                {
                    price = onePersonRoom * overnight;
                    price = price - (price * 0.10);
                }
                else if (kindOfRoom == "apartment" && rating == "positive")
                {
                    price = apartment * overnight;
                    price = price - (price * 0.50);
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "apartment" && rating == "negative")
                {
                    price = apartment * overnight;
                    price = price - (price * 0.50);
                    price = price - (price * 0.10);
                }
                else if (kindOfRoom == "president apartment" && rating == "positive")
                {
                    price = presidentApartment * overnight;
                    price = price - (price * 0.20);
                    price = price + (price * 0.25);
                }
                else if (kindOfRoom == "president apartment" && rating == "negative")
                {
                    price = presidentApartment * overnight;
                    price = price - (price * 0.20);
                    price = price - (price * 0.10);
                }
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
