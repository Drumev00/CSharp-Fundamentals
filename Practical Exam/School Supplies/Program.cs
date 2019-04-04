using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPens = int.Parse(Console.ReadLine());
            int amountOfMarkers = int.Parse(Console.ReadLine());
            double preparation = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double packetOfPens = 5.80;
            double packetOfMarkers = 7.20;
            double literPreparation = 1.20;

            double totalPens = packetOfPens * amountOfPens;
            double totalMarkers = packetOfMarkers * amountOfMarkers;
            double totalPreparation = literPreparation * preparation;
            double allStuff = totalPens + totalMarkers + totalPreparation;

            double result = allStuff - ((allStuff * discount) / 100); ;
            Console.WriteLine($"{result:F3}");
        }
    }
}
