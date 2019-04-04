using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int oneToyPrice = int.Parse(Console.ReadLine());

            double evenMoney = 0.00;
            double allMoney = 0;
            int toyCount = 0;
            int tookMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    evenMoney = (i * 10) / 2;
                    allMoney += evenMoney;
                    tookMoney++;
                }
                else
                {
                    toyCount++;
                }
            }

            int soldToys = toyCount * oneToyPrice;
            double result = (allMoney + soldToys) - tookMoney;

            if (result >= washingMachine)
            {
                Console.WriteLine($"Yes! {result - washingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - result:F2}");
            }

        }
    }
}
