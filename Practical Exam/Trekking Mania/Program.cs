using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfGroups = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            double allPeople = 0;

            for (int i = 1; i <= amountOfGroups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                allPeople += peopleInGroup;
                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    kilimanjaro += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else if (peopleInGroup >= 41)
                {
                    everest += peopleInGroup;
                }
            }

            double climbingMusala = musala / allPeople * 100;
            double climbingMonblan = monblan / allPeople * 100;
            double climbingKilimanjaro = kilimanjaro / allPeople * 100;
            double climbingK2 = k2 / allPeople * 100;
            double climbingEverest = everest / allPeople * 100;

            Console.WriteLine($"{climbingMusala:F2}%");
            Console.WriteLine($"{climbingMonblan:F2}%");
            Console.WriteLine($"{climbingKilimanjaro:F2}%");
            Console.WriteLine($"{climbingK2:F2}%");
            Console.WriteLine($"{climbingEverest:F2}%");
        }
    }
}
