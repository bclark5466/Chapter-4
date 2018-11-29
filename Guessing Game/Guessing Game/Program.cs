using System;
using static System.Console;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            int userNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);

            WriteLine("Please enter an integer between 1 and 10");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber > randomNumber)
            {
                Console.WriteLine("The number was {0}. Your guess of {1} was too high.", randomNumber, userNumber);
            }

            else if (userNumber == randomNumber)
            {
                WriteLine("The number was {0}. Your guess of {1} was correct.", randomNumber, userNumber);
            }

            else if (userNumber < randomNumber)
            {
                WriteLine("The number was {0}. Your guess of {1} was too low", randomNumber, userNumber);
            }
        }
    }
}
