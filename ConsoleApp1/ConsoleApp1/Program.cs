using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            double testScore;

            WriteLine("Please enter your GPA");
            gpa = Convert.ToDouble(ReadLine());

            WriteLine("Please enter your admittance test score");
            testScore = Convert.ToDouble(ReadLine());

            if ((gpa >= 3.0 && testScore >= 60)||(gpa <= 3.0 && testScore >= 80))
            {
                WriteLine("Congratulations, you've been accepted");
            }

            else
            {
                WriteLine("You're a reject");
            }

            
        }
    }
}
