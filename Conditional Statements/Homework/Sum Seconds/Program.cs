using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetitor = int.Parse(Console.ReadLine());
            int secondCompetitor = int.Parse(Console.ReadLine());
            int thirdCompetitor = int.Parse(Console.ReadLine());
            int totalTime = firstCompetitor + secondCompetitor + thirdCompetitor;

            if (totalTime <= 59)
            {
                if (totalTime >= 0 && totalTime <= 9)
                {
                    Console.WriteLine($"0:0{totalTime}");
                }
                else
                {
                    Console.WriteLine($"0:{totalTime}");
                }
            }
            else if (totalTime >= 60 && totalTime <= 119)
            {
                if (totalTime >= 60 && totalTime <= 69)
                {
                    Console.WriteLine($"1:0{totalTime - 60}");
                }
                else
                {
                    Console.WriteLine($"1:{totalTime - 60}");
                }
                
            }
            else if (totalTime >= 120 && totalTime <= 179)
            {
                if (totalTime >= 120 && totalTime <= 129)
                {
                    Console.WriteLine($"2:0{totalTime - 120}");
                }
                else
                {
                    Console.WriteLine($"2:{totalTime - 120}");
                }
            }
        }
    }
}
