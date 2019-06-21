using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            int counter = 1;

            while (true)
            {
                string passwordTries = Console.ReadLine();
                if (passwordTries == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (passwordTries != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                counter++;
            }
        }
    }
}
