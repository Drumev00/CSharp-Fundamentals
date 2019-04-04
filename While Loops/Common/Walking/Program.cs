using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int allSteps = 0;
            int steps = 0;
            while (allSteps < 10000)
            {
                if (command == "Going home")
                {
                    command = Console.ReadLine();
                    steps = int.Parse(command);
                    allSteps += steps;
                    if (allSteps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    else
                    {
                        int needed = 10000 - allSteps;
                        Console.WriteLine($"{needed} more steps to reach goal.");
                        break;
                    }

                }
                steps = int.Parse(command);
                allSteps += steps;
                if (allSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                command = Console.ReadLine();

                
            }
        }
    }
}
