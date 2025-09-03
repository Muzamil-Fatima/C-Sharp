// class
using System;

namespace My_Awesome_Program
{
    class Wizard
    {
        //   yeh jo ? mark laga hua hai yeh extera  hai error a raha tha is ko fix krny kay liye 
        public string? name;
        public string? favoriteSpell;
        public int spellSlots;
        public float experience;
        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots");
            }
        }
    }
    class tut6
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard();
            wizard01.name = "Parry Hopper";
            wizard01.favoriteSpell = "Unexpecto Patronum";
            wizard01.spellSlots = 2;
            wizard01.experience = 0f;
            //   Console.WriteLine("spell slots;" + wizard01.spellSlots);
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();
            Console.WriteLine("Experience" + wizard01.experience);
            //   Console.WriteLine("spell slots;" + wizard01.spellSlots);
            // Wait before closing
            Console.ReadKey();
        }
    }
}
// classes allow us to built our own data structures 