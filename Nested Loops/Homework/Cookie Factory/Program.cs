using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = string.Empty;
            int n = int.Parse(Console.ReadLine());
            bool eggs = false;
            bool flour = false;
            bool sugar = false;

            for (int i = 1; i <= n; i++)
            {
                product = Console.ReadLine();

                while (product != "Bake!")
                {
                    switch (product)
                    {
                        case "eggs": eggs = true; break;
                        case "flour": flour = true; break;
                        case "sugar": sugar = true; break;
                    }
                    product = Console.ReadLine();
                }
                if (eggs && flour && sugar)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                     eggs = false;
                     flour = false;
                     sugar = false;
                }
                else
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    i--;
                }
            }
        }
    }
}
