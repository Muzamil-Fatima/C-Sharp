using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Muzamil";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
            Console.WriteLine("Hello , What is your name ?");
            Console.ReadLine();
            Console.WriteLine("A proud knight named....");
            Console.ReadLine();
            Console.WriteLine("...walk asked him what he wanted to drink?");
            Console.ReadKey();
            Console.WriteLine("Drink is very tasty");
            Console.ReadLine();
        }
    }
}