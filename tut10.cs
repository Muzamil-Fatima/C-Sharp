using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetAlien();
            Console.WriteLine(".............");
            MeetAlien();
            MeetAlien();
            Console.ReadKey();
            void MeetAlien()
            {
                Random numberGen = new Random();
                string name = "x" + numberGen.Next(10, 9999);
                int age = numberGen.Next(10, 500);
                Console.WriteLine("Hi, I'm " + name);
                Console.WriteLine("I'm" + age + "years old.");
                Console.WriteLine("oh, and I'm an alien");
            }
        }
    }
}