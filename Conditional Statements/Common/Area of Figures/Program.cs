using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = side * side2;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());
                double area = (length * heigth) / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
