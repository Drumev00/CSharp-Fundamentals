using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int result = 0;

            for (int i = 0; i <= word.Length-1; i++)
            {
                char letter = word[i];

                switch (letter)
                {
                    case 'a':result += 1;break;
                    case 'e': result += 2; break;
                    case 'i': result += 3; break;
                    case 'o': result += 4; break;
                    case 'u': result += 5; break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
