using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int sumOfLetters = 0;
            int max = int.MinValue;
            string winnerName = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }

                for (int i = 0; i < command.Length; i++)
                {
                    char myLetter = command[i];
                    sumOfLetters += myLetter;
                    if (max < sumOfLetters)
                    {
                        max = sumOfLetters;
                        winnerName = command;
                    }
                }
                sumOfLetters = 0;
            }
            Console.WriteLine($"Winner is {winnerName} - {max}!");
        }
    }
}
