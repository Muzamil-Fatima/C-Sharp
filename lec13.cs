using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=> else if ladder
            int marks = 98;
            if (marks >= 80 && marks <= 100)
            {
                Console.Write("Topper!");
            }
            else if (marks >= 60 && marks < 80)
            {
                Console.Write("First!");
            }
            else if (marks >= 33 && marks < 60)
            {
                Console.Write("Pass!");
            }
            else
            {
                Console.Write("Fail");
            }
            Console.ReadLine();
        }
    }
}