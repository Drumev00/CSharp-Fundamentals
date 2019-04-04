using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = int.Parse(Console.ReadLine());
            int firstNumber = myNumber % 100;
            int finalFirstNumber = myNumber % 10;
            int secondNumber = firstNumber / 10;

            
            

            double result = 0;

            for (int i = 1; i <= finalFirstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    for (int k = 1; k <= myNumber / 100; k++)
                    {
                        result = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {result};");
                    }
                }
            }
        }
    }
}
