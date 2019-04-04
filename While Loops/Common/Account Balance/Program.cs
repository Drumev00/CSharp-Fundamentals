using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int installment = int.Parse(Console.ReadLine());
            int counter = 0;
            double balance = 0;

            while (counter != installment)
            {
                double addedMoney = double.Parse(Console.ReadLine());
                if (addedMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += addedMoney;
                Console.WriteLine($"Increase: {addedMoney:F2}");
                counter++;
            }
            Console.WriteLine($"Total: {balance:F2}");
        }
    }
}
