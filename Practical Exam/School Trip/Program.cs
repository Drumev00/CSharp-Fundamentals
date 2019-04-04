using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAbsence = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double firstDogsFoodForOneDay = double.Parse(Console.ReadLine());
            double secondDogsFoodForOneDay = double.Parse(Console.ReadLine());
            double thirdDogsFoodForOneDay = double.Parse(Console.ReadLine());

            double totalKilosForFirstDog = daysOfAbsence * firstDogsFoodForOneDay;
            double totalKilostForSecondDog = daysOfAbsence * secondDogsFoodForOneDay;
            double totalKilostForThirdDog = daysOfAbsence * thirdDogsFoodForOneDay;

            double totalFood = totalKilosForFirstDog + totalKilostForSecondDog + totalKilostForThirdDog;

            if (totalFood <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
