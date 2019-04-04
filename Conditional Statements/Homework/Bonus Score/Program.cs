using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double scores = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (scores <= 100)
            {
                bonus = bonus + 5;
                
            }
            if (scores > 100 && scores <= 1000)
            {
                bonus = scores * 0.20;
                
            }
            if (scores > 1000)
            {
                bonus = scores * 0.10;
                
            }

            if (scores % 2 == 0)
            {
                bonus = bonus + 1;
                
            }
            if (scores % 10 == 5)
            {
                bonus = bonus + 2;
                
            }



            Console.WriteLine(bonus);
            Console.WriteLine(scores + bonus);
        }
    }
}
