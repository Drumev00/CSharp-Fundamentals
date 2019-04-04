using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLength = double.Parse(Console.ReadLine());
            double shipHeigth = double.Parse(Console.ReadLine());
            double averageAstronautHeigth = double.Parse(Console.ReadLine());

            double shipValue = shipWidth * shipLength * shipHeigth;
            double roomValue = (averageAstronautHeigth + 0.40) * 2 * 2;

            double result = Math.Floor(shipValue / roomValue);
            
            if (result >= 3 && result <= 10)
            {
                Console.WriteLine($"The spacecraft holds {result} astronauts.");
            }
            else if (result < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (result > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
