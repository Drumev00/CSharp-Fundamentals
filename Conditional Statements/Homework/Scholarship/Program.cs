using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double excellentScholarship = 0;

            if (income > minSalary && averageSuccess < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            if (income < minSalary && averageSuccess >= 4.50)
            {
                socialScholarship = minSalary * 0.35;
            }
            if (averageSuccess >= 5.50)
            {
                excellentScholarship = averageSuccess * 25;
            }
            if (socialScholarship > excellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (socialScholarship < excellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
        }
    }
}
