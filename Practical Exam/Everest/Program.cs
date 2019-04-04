using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string restOrNo = string.Empty;
            int days = 1;
            int currentMeters = 5364;


            while (currentMeters < 8848)
            {
                restOrNo = Console.ReadLine();
                if (restOrNo == "Yes")
                {
                    days++;
                    if (days > 5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine($"{currentMeters}");
                        break;
                    }
                }
                else if (restOrNo == "END")
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{currentMeters}");
                    break;
                }
                int climbedMeters = int.Parse(Console.ReadLine());
                currentMeters += climbedMeters;
            }
            if (currentMeters >= 8848)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            
        }
    }
}
