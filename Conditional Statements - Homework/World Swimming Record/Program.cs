using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double distanceFor1MeterInSeconds = double.Parse(Console.ReadLine());

            double heMustSwim = distanceInMeters * distanceFor1MeterInSeconds;
            double afterSlow = Math.Floor(distanceInMeters / 15);
            Math.Floor(afterSlow = afterSlow * 12.5);
            double totalTime = heMustSwim + afterSlow;

            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:F2} seconds slower.");
            }
        }
    }
}
