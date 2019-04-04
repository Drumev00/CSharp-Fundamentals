using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            town.ToLower();
            double comissions = -1;

            if (town == "Sofia")
            {
                if (sales <= 500)
                {
                    comissions = sales * 0.05;
                }
                else if (sales <= 1000)
                {
                    comissions = sales * 0.07;
                }
                else if (sales <= 10000)
                {
                    comissions = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.12;
                }
                
            }
            else if (town == "Varna")
            {
                if (sales <= 500)
                {
                    comissions = sales * 0.045;
                }
                else if (sales <= 1000)
                {
                    comissions = sales * 0.075;
                }
                else if (sales <= 10000)
                {
                    comissions = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales <= 500)
                {
                    comissions = sales * 0.055;
                }
                else if (sales <= 1000)
                {
                    comissions = sales * 0.08;
                }
                else if (sales <= 10000)
                {
                    comissions = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comissions = sales * 0.145;
                }
            }

            if (comissions >= 0)
            {
                Console.WriteLine($"{comissions:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
