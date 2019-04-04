using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double result = -1;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    result = quantity * 2.50;
                    
                }
                else if (fruit == "apple")
                {
                    result = quantity * 1.20;
                    
                }
                else if (fruit == "orange")
                {
                    result = quantity * 0.85;
                    

                }
                else if (fruit == "grapefruit")
                {
                    result = quantity * 1.45;
                    
                }
                else if (fruit == "kiwi")
                {
                    result = quantity * 2.70;
                    
                }
                else if (fruit == "pineapple")
                {
                    result = quantity * 5.50;
                    
                }
                else if (fruit == "grapes")
                {
                    result = quantity * 3.85;
                    
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    result = quantity * 2.70;
                    
                }
                else if (fruit == "apple")
                {
                    result = quantity * 1.25;
                    
                }
                else if (fruit == "orange")
                {
                    result = quantity * 0.90;
                    

                }
                else if (fruit == "grapefruit")
                {
                    result = quantity * 1.60;
                    
                }
                else if (fruit == "kiwi")
                {
                    result = quantity * 3;
                    
                }
                else if (fruit == "pineapple")
                {
                    result = quantity * 5.60;
                    
                }
                else if (fruit == "grapes")
                {
                    result = quantity * 4.20;
                    
                }
            }

            if (result >= 0)
            {
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
