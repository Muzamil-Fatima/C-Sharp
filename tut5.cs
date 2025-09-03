using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=>for loop 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("How many cool number do you want: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
            //=> Wait before closing 
            Console.ReadKey();
        }
    }
}