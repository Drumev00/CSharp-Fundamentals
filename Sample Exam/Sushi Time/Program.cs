using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfSushi = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());

            double moneyCost = 0;
            bool isValid = false;

            if (restaurant == "Sushi Zone")
            {
                isValid = true;
                if (kindOfSushi == "sashimi" && order == 'N')
                {
                    moneyCost = portions * 4.99;
                }
                else if (kindOfSushi == "sashimi" && order == 'Y')
                {
                    moneyCost = portions * 4.99;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "maki" && order == 'N')
                {
                    moneyCost = portions * 5.29;
                }
                else if (kindOfSushi == "maki" && order == 'Y')
                {
                    moneyCost = portions * 5.29;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "uramaki" && order == 'N')
                {
                    moneyCost = portions * 5.99;
                }
                else if (kindOfSushi == "uramaki" && order == 'Y')
                {
                    moneyCost = portions * 5.99;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "temaki" && order == 'N')
                {
                    moneyCost = portions * 4.29;
                }
                else if (kindOfSushi == "temaki" && order == 'Y')
                {
                    moneyCost = portions * 4.29;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
            }
            else if (restaurant == "Sushi Time")
            {
                isValid = true;
                if (kindOfSushi == "sashimi" && order == 'N')
                {
                    moneyCost = portions * 5.49;
                }
                else if (kindOfSushi == "sashimi" && order == 'Y')
                {
                    moneyCost = portions * 5.49;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "maki" && order == 'N')
                {
                    moneyCost = portions * 4.69;
                }
                else if (kindOfSushi == "maki" && order == 'Y')
                {
                    moneyCost = portions * 4.69;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "uramaki" && order == 'N')
                {
                    moneyCost = portions * 4.49;
                }
                else if (kindOfSushi == "uramaki" && order == 'Y')
                {
                    moneyCost = portions * 4.49;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "temaki" && order == 'N')
                {
                    moneyCost = portions * 5.19;
                }
                else if (kindOfSushi == "temaki" && order == 'Y')
                {
                    moneyCost = portions * 5.19;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
            }
            else if (restaurant == "Sushi Bar")
            {
                isValid = true;
                if (kindOfSushi == "sashimi" && order == 'N')
                {
                    moneyCost = portions * 5.25;
                }
                else if (kindOfSushi == "sashimi" && order == 'Y')
                {
                    moneyCost = portions * 5.25;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "maki" && order == 'N')
                {
                    moneyCost = portions * 5.55;
                }
                else if (kindOfSushi == "maki" && order == 'Y')
                {
                    moneyCost = portions * 5.55;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "uramaki" && order == 'N')
                {
                    moneyCost = portions * 6.25;
                }
                else if (kindOfSushi == "uramaki" && order == 'Y')
                {
                    moneyCost = portions * 6.25;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "temaki" && order == 'N')
                {
                    moneyCost = portions * 4.75;
                }
                else if (kindOfSushi == "temaki" && order == 'Y')
                {
                    moneyCost = portions * 4.75;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
            }
            else if (restaurant == "Asian Pub")
            {
                isValid = true;
                if (kindOfSushi == "sashimi" && order == 'N')
                {
                    moneyCost = portions * 4.50;
                }
                else if (kindOfSushi == "sashimi" && order == 'Y')
                {
                    moneyCost = portions * 4.50;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "maki" && order == 'N')
                {
                    moneyCost = portions * 4.80;
                }
                else if (kindOfSushi == "maki" && order == 'Y')
                {
                    moneyCost = portions * 4.80;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "uramaki" && order == 'N')
                {
                    moneyCost = portions * 5.50;
                }
                else if (kindOfSushi == "uramaki" && order == 'Y')
                {
                    moneyCost = portions * 5.50;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
                else if (kindOfSushi == "temaki" && order == 'N')
                {
                    moneyCost = portions * 5.50;
                }
                else if (kindOfSushi == "temaki" && order == 'Y')
                {
                    moneyCost = portions * 5.50;
                    moneyCost = moneyCost + (moneyCost * 0.20);
                }
            }
            double result = Math.Ceiling(moneyCost);
            if (isValid)
            {
                Console.WriteLine($"Total price: {result} lv.");
            }
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }
        }
    }
}
