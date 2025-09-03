using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=>while loop
            int i = 20;
            while (i >= 1)
            {
                Console.WriteLine(i + " ");
                i--;
            }
            Console.ReadLine();
        }
    }
}