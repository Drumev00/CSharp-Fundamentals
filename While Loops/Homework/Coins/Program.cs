using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            money *= 100;
            int coins = 0;

            while (money >= 200)
            {
                money -= 200;
                coins++;
            }
            while (money >= 100)
            {
                money -= 100;
                coins++;
            }
            if (money >= 50)
            {
                money -= 50;
                coins++;
            }
            while (money >= 20)
            {
                money -= 20;
                coins++;
            }
            while (money >= 10)
            {
                money -= 10;
                coins++;
            }
            while (money >= 5)
            {
                money -= 5;
                coins++;
            }
            while (money >= 2)
            {
                money -= 2;
                coins++;
            }
            if (money >= 1)
            {
                money -= 1;
                coins++;
            }
            Console.WriteLine(coins);
        }
    }
}
