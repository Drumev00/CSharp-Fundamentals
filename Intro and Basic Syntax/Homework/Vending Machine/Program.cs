using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double moneySum = 0;

            while (command != "Start")
            {
                double insertedMoney = double.Parse(command);
                if (insertedMoney 
                    != 0.1 && insertedMoney 
                    != 0.2 && insertedMoney 
                    != 0.5 && insertedMoney 
                    != 1 && insertedMoney != 2)
                {
                    Console.WriteLine($"Cannot accept {insertedMoney}");
                }
                if (insertedMoney
                    == 0.1 || insertedMoney
                    == 0.2 || insertedMoney
                    == 0.5 || insertedMoney
                    == 1 || insertedMoney == 2)
                {
                    moneySum += insertedMoney;
                }
                command = Console.ReadLine();
            }

            string products = Console.ReadLine();

            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;

            while (products != "End")
            {
                if (products
                    != "Coke" && products
                    != "Soda" && products
                    != "Crisps" && products
                    != "Water" && products
                    != "Nuts")
                {
                    Console.WriteLine("Invalid product");
                }
                if (products == "Nuts")
                {
                    if (moneySum - nuts < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        moneySum -= nuts;
                        Console.WriteLine("Purchased nuts");
                    }
                }
                if (products == "Water")
                {
                    if (moneySum - water < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        moneySum -= water;
                        Console.WriteLine("Purchased water");
                    }
                }
                if (products == "Crisps")
                {
                    if (moneySum - crisps < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        moneySum -= crisps;
                        Console.WriteLine("Purchased crisps");
                    }
                }
                if (products == "Soda")
                {
                    if (moneySum - soda < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        moneySum -= soda;
                        Console.WriteLine("Purchased soda");
                    }
                }
                if (products == "Coke")
                {
                    if (moneySum - coke < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        moneySum -= coke;
                        Console.WriteLine("Purchased coke");
                    }
                }
                products = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneySum:F2}");
        }
    }
}
