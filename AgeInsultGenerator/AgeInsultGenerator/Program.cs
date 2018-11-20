using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            string yesString;
            int yes;
            WriteLine("Welcome to the Age Insult Generator");
            WriteLine("Please enter your alleged age");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);

            if (age < 18)
            {
                WriteLine("You are a minor that cannot even vote, hahahaha");

            }
            else if (age >= 18 && age < 25)
            {
                WriteLine("You should be in college or finished with college by now. You should not be a deadbeat");
            }
            else if (age >= 25 && age < 32)
            {
                WriteLine("Do You have a job? 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                {
                    WriteLine("Good for you, you're a slave to the system");
                }
                else
                {
                    WriteLine ("Get a job you hippie");
                }
            }
            else if (age >= 32 && age < 42)
            {
                WriteLine("Is that a bald spot I see?");
            }
            else if (age >= 42 && age < 52) 
            {
                WriteLine("Good job wasting half of your life");
            }
            else if (age >= 52 && age < 62)
            {
                WriteLine("At this point, all you have to look forwards to is death");
            }
            else if (age > 62)
            {
                WriteLine("At this point you're just wasting oxygen. Go die already");
            }
            ReadLine();
        }
    }
}
