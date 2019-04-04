using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            double moneyOnHand = double.Parse(Console.ReadLine());
            int counter = 1;
            int spendMeter = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    moneyOnHand -= sum;
                    spendMeter++;
                    if (moneyOnHand < 0)
                    {
                        moneyOnHand = 0;
                    }
                }
                if (spendMeter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{counter}");
                    break;
                }
                else if (action == "save")
                {
                    moneyOnHand += sum;
                    spendMeter = 0;
                }
                if (moneyOnHand >= vacation)
                {
                    Console.WriteLine($"You saved the money for {counter} days.");
                    break;
                }
                counter++;
            }
        }
    }
}
