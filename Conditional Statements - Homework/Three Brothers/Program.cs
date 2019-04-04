using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherClean = double.Parse(Console.ReadLine());
            double secondBrotherClean = double.Parse(Console.ReadLine());
            double thirdrotherClean = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double totalTimeClean = 1 / (1 / firstBrotherClean + 1 / secondBrotherClean + 1 / thirdrotherClean);
            double timeWithRest = totalTimeClean * 0.15;
            totalTimeClean += timeWithRest;
            double timeLeft = fishingTime - totalTimeClean;

            Console.WriteLine($"Cleaning time: {totalTimeClean:F2}");

            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Abs(Math.Floor(timeLeft))} hours.");
            }
        }
    }
}
