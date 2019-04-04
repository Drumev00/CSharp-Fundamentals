using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int counter = 0;

            while (true)
            {
                string currentBook = Console.ReadLine();
                if (currentBook == book)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                else if (counter == capacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    break;
                }
                counter++;
            }
        }
    }
}
