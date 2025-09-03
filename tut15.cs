// Array
using System;

namespace MyFirstArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size
            string[] cars = new string[3]; // declaring the array
                                           //  string [] cars = {"BMW" , "Mustang", "Corvette"};
            cars[0] = "Tesla";// assigning the array 
            cars[1] = "BMW";
            cars[2] = "Mustang";
            cars[3] = "Corvette";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            //  Console.WriteLine(cars[0]);
            //  Console.WriteLine(cars[1]);
            //  Console.WriteLine(cars[2]);
            // you have ensure that the element can't access whose can't present in the
            //  Console.WriteLine(cars[3]);
            Console.ReadLine();
        }
    }
}
