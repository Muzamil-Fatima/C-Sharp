using System;
namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=>Ak header file upar attach ki hai.using System.Collection.Generic; 
            List<string> shoppingList = new List<string>();
            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            shoppingList.Remove("Dream");
            shoppingList.RemoveAt(1);
            Console.WriteLine("........");
            Console.ReadKey();
        }
    }
}