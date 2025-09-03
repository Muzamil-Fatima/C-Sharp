using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] movie = { "Lord of the Rings", "Fight Club", "Interstellar", "Gladiator" };
            for (int i = 0; i < 4; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + "." + movie[i]);
            }
            Console.ReadKey();
        }
    }
}