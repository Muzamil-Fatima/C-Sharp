using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=> if else loop
            int age = 34;
            if (age >= 18)
            {
                Console.Write("Eligible for vote !");
            }
            else
            {
                Console.Write("Not Eligible for vote !");
            }
            Console.ReadLine();
        }
    }
}