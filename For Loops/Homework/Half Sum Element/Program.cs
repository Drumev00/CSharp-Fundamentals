using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input > max)
                {
                    max = input;
                }
                sum += input;
            }
            sum -= max;
            int diff = Math.Abs(max - sum);

            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
