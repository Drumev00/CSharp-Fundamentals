using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersAtStart = int.Parse(Console.ReadLine());
            int amountOfStops = int.Parse(Console.ReadLine());

            int passengersNow = 0;
            for (int i = 1; i <= amountOfStops; i++)
            {
                int passengersOut = int.Parse(Console.ReadLine());
                int passengersIn = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    passengersNow = (passengersAtStart - passengersOut) + passengersIn;
                }
                else
                {
                    passengersNow = (passengersNow - passengersOut) + passengersIn;
                }

                if (i % 2 == 0)
                {
                    passengersNow = passengersNow - 2;
                }
                else
                {
                    passengersNow = passengersNow + 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passengersNow}");
        }
    }
}
