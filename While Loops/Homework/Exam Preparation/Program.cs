using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unwantedGrades = int.Parse(Console.ReadLine());
            double sumOfGrades = 0;
            int counter = 0;
            string previousEx = string.Empty;
            int currentBadGrades = 0;

            while (true)
            {
                string exerciseName = Console.ReadLine();
                if (exerciseName != "Enough")
                {
                    previousEx = exerciseName;
                }
                if (exerciseName == "Enough")
                {
                    double average = sumOfGrades / counter;
                    Console.WriteLine($"Average score: {average:F2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {previousEx}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    currentBadGrades++;
                }

                sumOfGrades += grade;

                if (currentBadGrades == unwantedGrades)
                {
                    Console.WriteLine($"You need a break, {currentBadGrades} poor grades.");
                    break;
                }
                counter++;


            }
        }
    }
}
