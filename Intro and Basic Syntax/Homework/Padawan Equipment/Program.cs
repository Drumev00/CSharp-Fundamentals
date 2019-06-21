using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivansMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double oneSabre = double.Parse(Console.ReadLine());
            double oneRobe = double.Parse(Console.ReadLine());
            double oneBelt = double.Parse(Console.ReadLine());

            double studentsForSabers = students;

            studentsForSabers = Math.Ceiling(students + (students * 0.10));
            double allSabers = oneSabre * studentsForSabers;
            
            double allRobes = oneRobe * students;

            int studentsGettingFreeStuff = students / 6;
            students -= studentsGettingFreeStuff;
            
            double allBelts = oneBelt * students;


            double totalSum = allBelts + allRobes + allSabers;
            

            if (ivansMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalSum - ivansMoney:F2}lv more.");
            }
        }
    }
}
