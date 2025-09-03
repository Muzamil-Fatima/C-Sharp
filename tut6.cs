using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //=> While Loop:
            Random numberGen = new Random();
            int roll = 0;
            int attempts = 0;
            Console.WriteLine("Press enter to roll the die");
            while (roll != 6)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }
            Console.WriteLine("It took you " + attempts + " attempts to roll a six.");
            Console.ReadKey();
        }
    }
}