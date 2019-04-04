using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeWidth = int.Parse(Console.ReadLine());
            int freeLength = int.Parse(Console.ReadLine());
            int freeHeight = int.Parse(Console.ReadLine());
            int freeCubicMeters = freeWidth * freeLength * freeHeight;
            int allBosex = 0;

            while (true)
            {
                string amountOfBoxes = Console.ReadLine();
                if (amountOfBoxes == "Done")
                {
                    Console.WriteLine($"{freeCubicMeters - allBosex} Cubic meters left.");
                    break;
                }
                int boxesInNumbers = int.Parse(amountOfBoxes);
                allBosex += boxesInNumbers;
                if (allBosex > freeCubicMeters)
                {
                    Console.WriteLine($"No more free space! You need {allBosex - freeCubicMeters} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
