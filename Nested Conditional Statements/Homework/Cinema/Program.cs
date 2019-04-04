using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfProject = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colomns = int.Parse(Console.ReadLine());
            double price = 0;
            double income = 0;

            int allChairs = rows * colomns;

            if (kindOfProject == "Premiere")
            {
                price = 12.00;
                income = price * allChairs;
            }
            else if (kindOfProject == "Normal")
            {
                price = 7.50;
                income = price * allChairs;
            }
            else if (kindOfProject == "Discount")
            {
                price = 5.00;
                income = price * allChairs;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
