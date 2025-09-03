using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("Enter Array Element");
            for (int i = 0; i < 2; ++i)//rows
            {
                for (int j = 0; j < 2; ++j)//colums
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Array Element");

            for (int i = 0; i < 2; ++i)//rows
            {
                for (int j = 0; j < 2; ++j)//colums
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}