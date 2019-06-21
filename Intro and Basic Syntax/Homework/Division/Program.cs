using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = int.Parse(Console.ReadLine());



            if (myNumber % 2 == 0 && myNumber % 6 != 0 && myNumber % 10 != 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else if (myNumber % 3 == 0 && myNumber % 6 != 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (myNumber % 2 == 0 && myNumber % 3 == 0 && myNumber % 10 != 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (myNumber % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (myNumber % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }




        }
    }
}
