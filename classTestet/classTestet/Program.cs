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
            hero.newAtk(hero, villain);
            // newAtk(int dmg, int dm2,) from newAtk() method.
            //newAtk(hero, villain);
        }
        //Randomizes the object's value and presents the winner with the highest Atk.
        
    }

}
