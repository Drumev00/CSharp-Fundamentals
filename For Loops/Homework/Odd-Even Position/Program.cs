using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = 1000000.0;
            double oddMax = -1000000.0;
            double evenSum = 0;
            double evenMin = 1000000.0;
            double evenMax = -1000000.0;

            for (int i = 1; i <= n; i++)
            {
                double myNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += myNumber;
                    if (myNumber < evenMin)
                    {
                        evenMin = myNumber;
                    }
                    if (myNumber > evenMax)
                    {
                        evenMax = myNumber;
                    }
                }
                else
                {
                    oddSum += myNumber;
                    if (myNumber < oddMin)
                    {
                        oddMin = myNumber;
                    }
                    if (myNumber > oddMax)
                    {
                        oddMax = myNumber;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum},");
            if (oddMin == 1000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin},");
            }
            if (oddMax == -1000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax},");
            }
            
            Console.WriteLine($"EvenSum={evenSum},");
            if (evenMin == 1000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin},");
            }
            if (evenMax == -1000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax}");
            }
            
        }
    }
}
