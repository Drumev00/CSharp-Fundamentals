using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "END")
                {
                    Console.WriteLine($"Max number: {max}");
                    Console.WriteLine($"Min number: {min}");
                    break;
                }
                int num = int.Parse(command);
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                command = Console.ReadLine();
            }
        }
    }
}
