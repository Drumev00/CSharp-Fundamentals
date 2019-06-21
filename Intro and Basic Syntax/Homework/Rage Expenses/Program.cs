using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = 0;

            for (int i = 1; i <= trashedKeyboard; i++)
            {
                if (i % 2 == 0)
                {
                    trashedDisplay++;
                }
            }
            


            double headsetMoney = headsetPrice * trashedHeadset;
            double mouseMoney = mousePrice * trashedMouse;
            double keyboardMoney = keyboardPrice * trashedKeyboard;
            double displayMoney = displayPrice * trashedDisplay;

            double totalSum = headsetMoney + mouseMoney + keyboardMoney + displayMoney;

            Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");

        }
    }
}
