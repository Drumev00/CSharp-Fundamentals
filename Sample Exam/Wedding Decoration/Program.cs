using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double oneBalloon = 0.1;
            double oneFlower = 1.5;
            double oneCandle = 0.5;
            double oneMeterRibbon = 2;

            double result = 0;
            double totalMoneySpend = 0;
            double amountOfBalloons = 0;
            double amountOfFlowers = 0;
            double amountOfCandles = 0;
            double amountOfRibbons = 0;

            while (budget > 0)
            {
                string stock = Console.ReadLine();
                if (stock == "stop")
                {
                    double moneyLeft = budget - totalMoneySpend;
                    Console.WriteLine($"Spend money: {totalMoneySpend:F2}");
                    Console.WriteLine($"Money left: {moneyLeft + totalMoneySpend:F2}");
                    Console.WriteLine($"Purchased decoration is {amountOfBalloons} balloons, {amountOfRibbons} m ribbon, " +
                $"{amountOfFlowers} flowers and {amountOfCandles} candles.");
                    break;
                }
                int amountOfStock = int.Parse(Console.ReadLine());
                if (stock == "balloons")
                {
                    result = amountOfStock * oneBalloon;
                    totalMoneySpend += result;
                    budget = budget - result;
                    amountOfBalloons += amountOfStock;
                }
                else if (stock == "flowers")
                {
                    result = amountOfStock * oneFlower;
                    totalMoneySpend += result;
                    budget = budget - result;
                    amountOfFlowers += amountOfStock;
                }
                else if (stock == "candles")
                {
                    result = amountOfStock * oneCandle;
                    totalMoneySpend += result;
                    budget = budget - result;
                    amountOfCandles += amountOfStock;
                }
                else if (stock == "ribbon")
                {
                    result = amountOfStock * oneMeterRibbon;
                    totalMoneySpend += result;
                    budget = budget - result;
                    amountOfRibbons += amountOfStock;
                }
            }
            if (budget <= 0)
            {
                Console.WriteLine("All money is spent!");
                Console.WriteLine($"Purchased decoration is {amountOfBalloons} balloons, {amountOfRibbons} m ribbon, " +
                    $"{amountOfFlowers} flowers and {amountOfCandles} candles.");
            }
            
            
        }
    }
}
