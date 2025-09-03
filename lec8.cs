using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=>Do While
            int i = 1;
            do
            {
                Console.WriteLine(i);
                ++i;
            }
            while (i <= 10);
            Console.ReadLine();
            // for loop 
            for (int m = 0; m < 5; m++)
            {
                Console.WriteLine(m + " ");
            }
            Console.ReadLine();
        }
    }
}