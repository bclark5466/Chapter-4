using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            WriteLine ("Please enter a number");

            number = Convert.ToInt32(ReadLine());

            if (number == 1)
            {
                WriteLine("You failed at stealing Hank Hill's propane and propane accessories. He attacks you with his wedge. You died");
            }

            else if (number == 2)
            {
                WriteLine("Congratulations, you win!!");
            }

            else if (number == 3)
            {
                WriteLine("The Hulk pimp-slapped you across the room. You died");
            }

            else
            {
                WriteLine("Learn to follow instructions, loser");
            }


        }
    }
}
