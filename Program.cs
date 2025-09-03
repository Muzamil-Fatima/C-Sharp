// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Methods & Function Code with harry
//class ak blue print hota hai objects ko represent krny kay liye 
using System;
class Program
{
    static void Great(string name)
    {
        Console.WriteLine("Hello World! Good Morning" + name);
    }
    // static int See()
    // {
    //     Console.WriteLine("Hello World! Good Morning");
    //     return 56;
    // }
    static float Average(int a, int b, int c)
    {
        float sum = a + b + c;
        return sum / 3;
    }
    static float Average(int a, int b)
    {
        return (a + b) / 2;
    }
    static void Main(string[] args)
    {
        Great(" Muzamil");
        Great(" Fatima");
        Great(" Mughal");
        Console.WriteLine(Average(23, 34, 56));
        float temp = Average(3, 5, 6);
        Console.WriteLine(temp);
        Console.WriteLine(Average(3, 4, 6));
        Console.WriteLine(Average(3, 4));
        Console.ReadLine();
    }
}