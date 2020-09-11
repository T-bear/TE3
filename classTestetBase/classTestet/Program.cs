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

            void newAtk(int dmg, int dmg2)
            {
                int x = _r.Next(dmg);
                int y = _r.Next(dmg2);
                Console.WriteLine(hero.Name + " Strikes with the power of " + x + "\n");
                Console.WriteLine(villain.Name + " Strikes with the power of " + y + "\n");
                if (x > y)
                {
                    Console.WriteLine("The winner is " + hero.Name + "!!!");
                }
                else
                {
                    Console.WriteLine("The winner is " + villain.Name + "!!!");
                }
            }

            newAtk(hero.Atk, villain.Atk);
        }


    }
}
