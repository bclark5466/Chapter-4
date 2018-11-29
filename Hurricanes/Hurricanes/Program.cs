using System;
using static System.Console;

namespace Hurricanes
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed;

            WriteLine("What is the current wind speed?");
            speed = Convert.ToDouble(Console.ReadLine());

            if (speed >= 157)
            {
                WriteLine("You are in a category 5 hurricane. You're probably dead already");
            }
            else if (speed < 157 && speed >= 130)
            {
                WriteLine("This is a category 4 hurricane. You just might survive");
            }
            else if (speed < 130 && speed >= 111)
            {
                WriteLine("It's a category 2. If you aren't headbanging into the wind and waving an American flag, leave this country now.");
            }
            else if (speed < 111 && speed >= 96)
            {
                WriteLine("A category 2. Just chill indoors a bit");
            }
            else if (speed < 96 && speed >= 74)
            {
                WriteLine("It's just a category 1. Go about your regular life.");
            }
            else if (speed < 74)
            {
                WriteLine("It aint even a hurricane you coward");
            }
        }
    }
}
