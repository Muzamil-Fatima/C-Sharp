using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=> Switch statement 
            int ch;
            Console.Write("Enter Your Chice!");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.Write("Muzamil");
                    break;
                case 2:
                    Console.Write("Fatima");
                    break;
                default:
                    Console.Write("Invalid Choice! ");
                    break;
            }
            Console.ReadLine();
            int a = 1, b = 2, c = 3, d = 4, e = 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}