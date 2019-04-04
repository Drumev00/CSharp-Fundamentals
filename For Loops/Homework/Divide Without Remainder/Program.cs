using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double divideBy2 = 0;
            double divideBy3 = 0;
            double divideBy4 = 0;

            for (int i = 1; i <= n; i++)
            {
                int myNumber = int.Parse(Console.ReadLine());

                if (myNumber % 2 == 0)
                {
                    divideBy2++;
                }
                if (myNumber % 3 == 0)
                {
                    divideBy3++;
                }
                if (myNumber % 4 == 0)
                {
                    divideBy4++;
                }
            }
            double p1 = (divideBy2 / n) * 100;
            double p2 = (divideBy3 / n) * 100;
            double p3 = (divideBy4 / n) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
