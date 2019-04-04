using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int travelToTown = int.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - travelToTown;
            weekendsInSofia = weekendsInSofia * (3.0 / 4);

            double gamesInTown = travelToTown;
            double holidayGames = holidays * (2.0 / 3);

            double allGames = weekendsInSofia + gamesInTown + holidayGames;

            if (year == "leap")
            {
                allGames = allGames + (allGames* 0.15);
            }
            Console.WriteLine($"{Math.Truncate(allGames)}");
        }
    }
}
