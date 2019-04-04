using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int area = width * length;

            string command = Console.ReadLine().ToLower();
            int piecesEaten = 0;

            while (command != "stop")
            {
                int pieces = int.Parse(command);
                piecesEaten += pieces;
                if (piecesEaten > area)
                {
                    Console.WriteLine($"No more cake left! You need {piecesEaten - area} pieces more.");
                    break;
                }
                command = Console.ReadLine().ToLower();
            }

            if (area > piecesEaten)
            {
                Console.WriteLine($"{area - piecesEaten} pieces are left.");
            }
            

        }
    }
}
