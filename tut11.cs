using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiply(12, 45);
            Console.ReadKey();

            void Multiply(int num01, int num02)
            {
                int result = num01 * num02;
                Console.WriteLine("The result is: " + result);
            }
        }
    }
}