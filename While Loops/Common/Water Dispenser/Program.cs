using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Dispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            int mililiters = 0;
            int counter = 0;

            while (mililiters < volume)
            {
                string button = Console.ReadLine();
                if (button == "Easy")
                {
                    mililiters += 50;
                }
                if (button == "Medium")
                {
                    mililiters += 100;
                }
                if (button == "Hard")
                {
                    mililiters += 200;
                }
                counter++;
            }
            if (mililiters == volume)
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }
            else if (mililiters > volume)
            {
                Console.WriteLine($"{mililiters - volume}ml has been spilled.");
            }
        }
    }
}
