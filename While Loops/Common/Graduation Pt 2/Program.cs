using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation_Pt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sum = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                }
                else if (grade < 4)
                {
                    grade = double.Parse(Console.ReadLine());
                    if (grade < 4)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        break;
                    }
                    else
                    {
                        grade = double.Parse(Console.ReadLine());
                        sum += grade;
                    }
                }
                counter++;
            }

            double average = sum / 12;
            if (counter == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
