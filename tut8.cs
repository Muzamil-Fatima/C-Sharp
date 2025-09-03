using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];
            Console.WriteLine("Type in four movie:");
            movies[0] = Console.ReadLine();
            movies[1] = Console.ReadLine();
            movies[2] = Console.ReadLine();
            movies[3] = Console.ReadLine();
            Console.WriteLine("/nHere they are alphabatically:");
            Array.Sort(movies);
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
            Console.ReadKey();
        }
    }
}