using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = string.Empty;
            double savedMoney = 0;
            double totalSavedMoney = 0;

            while (true)
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double requiredMoney = double.Parse(Console.ReadLine());

                while (totalSavedMoney <= requiredMoney)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    totalSavedMoney += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                totalSavedMoney = 0;
            }
        }
    }
}
