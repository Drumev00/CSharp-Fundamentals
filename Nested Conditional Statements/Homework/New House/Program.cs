using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFlower = Console.ReadLine();
            int amountOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;

            double rose = 5.00;
            double dahlia = 3.80;
            double tulip = 2.80;
            double narcissus = 3.00;
            double gladiolus = 2.50;

            if (kindOfFlower == "Roses")
            {
                price = amountOfFlowers * rose;
                if (amountOfFlowers > 80 )
                {
                    price = price - (price * 0.10);
                }
            }
            else if (kindOfFlower == "Dahlias")
            {
                price = amountOfFlowers * dahlia;
                if (amountOfFlowers > 90)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (kindOfFlower == "Tulips")
            {
                price = amountOfFlowers * tulip;
                if (amountOfFlowers > 80)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (kindOfFlower == "Narcissus")
            {
                price = amountOfFlowers * narcissus;
                if (amountOfFlowers < 120)
                {
                    price = price + (price * 0.15);
                }
            }
            else if (kindOfFlower == "Gladiolus")
            {
                price = amountOfFlowers * gladiolus;
                if (amountOfFlowers < 80)
                {
                    price = price + (price * 0.20);
                }
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountOfFlowers} {kindOfFlower} and {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }

        }
    }
}
