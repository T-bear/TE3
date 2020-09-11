using System;
using System.Globalization;

namespace classTestet
{
    class Program
    {
        static readonly Random _r = new Random();


        static void Main(string[] args)
        {
            var hero = new Character("Gilgamesh", "The hero", 10);
            var villain = new Character("Imhotep", "The villain", 10);

            newAtk(hero, villain);
        }

        static void newAtk (Character Attacker, Character Attacked) {
            int x = _r.Next(Attacker.Atk);
            int y = _r.Next(Attacked.Atk);
            Console.WriteLine(hero.Name + " Strikes with the power of " + x + "\n");
            Console.WriteLine(villain.Name + " Strikes with the power of " + y + "\n");
            if (x > y) {
                Console.WriteLine("The winner is " + Attacker.Name + "!!!");
            } else {
                Console.WriteLine("The winner is " + Attacked.Name + "!!!");
            }
        }

    }
}
