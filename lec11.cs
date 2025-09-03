using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=> nested if statement 
            int a = 10,
                b = 20,
                c = 30;
            if (b > a)
            {
                if (b > c)
                {
                    Console.Write("The greater number is b");
                }
                else
                {
                    Console.Write("The greater number is c");
                }
            }
            else
            {
                Console.Write("The greater number is a");
            }
            Console.ReadLine();
        }
    }
}