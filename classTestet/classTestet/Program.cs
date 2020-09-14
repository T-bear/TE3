using System;
using System.Globalization;

namespace classTestet
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Creating two objects with two string values and one integer value.
            var hero = new Character("Gilgamesh", "The hero", 10);
            var villain = new Character("Imhotep", "The villain", 10);
            // newAtk(int dmg, int dm2,) from newAtk() method in Character class.
            hero.newAtk(hero, villain);
        }
        
        
    }

}
