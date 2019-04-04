using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoney = double.Parse(Console.ReadLine());
            int amountOfPuzzles = int.Parse(Console.ReadLine());
            int amountOfDolls = int.Parse(Console.ReadLine());
            int amountOfBears = int.Parse(Console.ReadLine());
            int amountOfMinions = int.Parse(Console.ReadLine());
            int amountOfTrucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double sellMoney = (amountOfPuzzles * puzzlePrice) +
                (amountOfDolls * dollPrice) +
                (amountOfBears * bearPrice) +
                (amountOfMinions * minionPrice) +
                (amountOfTrucks * truckPrice);

            sellMoney = sellMoney - (sellMoney * 0.10);

            if ((amountOfPuzzles + amountOfDolls + amountOfBears + amountOfMinions + amountOfTrucks) >= 50)
            {
                sellMoney = sellMoney - (sellMoney * 0.25);
            }

            

            if (sellMoney >= vacationMoney)
            {
                Console.WriteLine($"Yes! {sellMoney - vacationMoney:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationMoney - sellMoney:F2} lv needed.");
            }
        }
    }
}
