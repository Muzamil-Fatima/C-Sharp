using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            int a = 100, b = 50;
            int r = (a > b) ? a : b;
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}