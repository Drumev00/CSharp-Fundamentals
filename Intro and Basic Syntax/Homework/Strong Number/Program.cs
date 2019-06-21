using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = int.Parse(Console.ReadLine());
            int myProbeNumber = myNumber;
            int sum = 0;
            
            while (myProbeNumber > 0)
            {
                int lastDigit = myProbeNumber % 10;
                myProbeNumber /= 10;

                int currentFactoarial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    currentFactoarial *= i;
                }

                sum += currentFactoarial;
            }

            if (sum == myNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }   

        
    }
}
