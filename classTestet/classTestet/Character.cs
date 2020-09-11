using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace classTestet
{
    public class Character
    {
        private string name = "";
        private string title = "";
        public int atk;
        static readonly Random _r = new Random();


        public Character(string name, string title, int atk)
        {
            this.name = name;
            this.title = title;
            this.atk = atk;

        }

        public string Name
        {
            get { return name; }
            set { name = Name; }
        }
        public string Title
        {
            get { return title; }
            set { title = Title; }
        }

        public int Atk
        {
            get { return atk; }
            set { atk = Atk; }
        }
        public override string ToString()
        {
            return name + " " + title;
        }

        public void newAtk(Character attacker, Character attacked)
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
