using System;
namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            //=>data type and variable
            int x = 10;
            x = 20;
            Console.WriteLine("The value of a is = " + x);
            double num = 45.7;
            Console.WriteLine("The value of num = " + num);
            string str = "Muzamil";
            Console.WriteLine("Value of string = " + str);
            Console.ReadLine();
            //=> user sy do number lyny hai aur phr in ko add krna hai 
            int a, b, r;
            Console.Write("Enter Any two Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            Console.Write("Sum of two number :" + r);
            Console.ReadLine();
        }
    }
}