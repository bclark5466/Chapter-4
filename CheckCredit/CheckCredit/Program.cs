using System;
using static System.Console;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int price;

            WriteLine("What was the value of your purchase?");
            price = Convert.ToInt32(ReadLine());

            if (price > 5000)
            {
                WriteLine("You spent too much you moron");
            }
            else
            {
                WriteLine("Purchase approved");
            }

        }
    }
}
