using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Odd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int i = 1; i <= n; i++)
            {
                int myNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += myNumber;
                }
                else
                {
                    odd += myNumber;
                }
            }
            int diff = Math.Abs(even - odd);
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
