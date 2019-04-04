using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                if (i <= n)
                {
                    int leftSide = int.Parse(Console.ReadLine());
                    leftSum += leftSide;
                }
                else
                {
                    int rightSide = int.Parse(Console.ReadLine());
                    rightSum += rightSide;

                }
            }
            int diff = Math.Abs(leftSum - rightSum);
            if (leftSum - rightSum == 0)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                
                Console.WriteLine($"No, diff = {diff}");
            }


        }
    }
}
