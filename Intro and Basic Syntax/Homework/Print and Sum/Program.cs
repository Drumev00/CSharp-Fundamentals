using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNumber = int.Parse(Console.ReadLine());
            int highNumber = int.Parse(Console.ReadLine());

            int sum = 0;


            for (int i = lowNumber; i <= highNumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
