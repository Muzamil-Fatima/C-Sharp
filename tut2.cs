using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;
            Console.Write("Input a  first number: ");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second  number: ");
            num02 = Convert.ToDouble(Console.ReadLine());
            double result = num01 * num02;
            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }
    }
}