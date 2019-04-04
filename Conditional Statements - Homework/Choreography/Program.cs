using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = int.Parse(Console.ReadLine());
            double dancers = int.Parse(Console.ReadLine());
            double learningDays = int.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(1 * 100 / learningDays);
            double stepsForEachDancer = stepsPerDay / dancers;

            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsForEachDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsForEachDancer:F2}% steps to be learned per day.");
            }
            
        }
    }
}
