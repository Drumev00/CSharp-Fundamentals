using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double under200 = 0;
            double under399 = 0;
            double under599 = 0;
            double under799 = 0;
            double over800 = 0;

            for (int i = 1; i <= n; i++)
            {
                int myNumber = int.Parse(Console.ReadLine());

                if (myNumber < 200)
                {
                    under200++;
                }
                if (myNumber >= 200 && myNumber <= 399)
                {
                    under399++;
                }
                if (myNumber >= 400 && myNumber <= 599)
                {
                    under599++;
                }
                if (myNumber >= 600 && myNumber <= 799)
                {
                    under799++;
                }
                if (myNumber >= 800)
                {
                    over800++;
                }
            }
            double p1 = (under200 / n) * 100;
            double p2 = (under399 / n) * 100;
            double p3 = (under599 / n) * 100;
            double p4 = (under799 / n) * 100;
            double p5 = (over800 / n) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");

        }
    }
}
