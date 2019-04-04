using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__GCD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = 0;

            if (a != b)
            {
                while ((a != 0) && (b != 0))
                {
                    result = a;
                    a = a % b;
                    b = b % result;
                }
                if (a == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
