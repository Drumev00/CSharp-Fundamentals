using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double litresOfGasoline = (420.0 / 100.0) * 7;
            double gasolineMoney = litresOfGasoline * 1.85;

            double totalFoodAndSouvenirs = (3 * foodMoney) + (3 * souvenirMoney);

            double firstDay = hotelMoney - (hotelMoney * 0.10);
            double secondDay = hotelMoney - (hotelMoney * 0.15);
            double thirdDay = hotelMoney - (hotelMoney * 0.20);

            double result = gasolineMoney + totalFoodAndSouvenirs + firstDay + secondDay + thirdDay;

            Console.WriteLine($"Money needed: {result:F2}");
        }
    }
}
