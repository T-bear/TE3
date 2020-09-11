using System;
using System.Globalization;

namespace classTestet
{
    class Program
    {
        static readonly Random _r = new Random();

        static void Main(string[] args)
        {
            //Creating two objects with two string values and one integer value.
            var hero = new Character("Gilgamesh", "The hero", 10);
            var villain = new Character("Imhotep", "The villain", 10);

            // newAtk(int dmg, int dm2,) from newAtk() method.
            newAtk(hero, villain);
        }
        //Randomizes the object's value and presents the winner with the highest Atk.
        static void newAtk(Character attacker, Character attacked)
        {
            
            int x = _r.Next(attacker.Atk);
            int y = _r.Next(attacked.Atk);
            Console.WriteLine(attacker.Name + " Strikes with the power of " + x + "\n");
            Console.WriteLine(attacked.Name + " Strikes with the power of " + y + "\n");
            if (x > y)
            {
                Console.WriteLine("The winner is " + attacker.Name + "!!!");
            }
            else
            {
                Console.WriteLine("The winner is " + attacked.Name + "!!!");
            }
        }
    }

}
