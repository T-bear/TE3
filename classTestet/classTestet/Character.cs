using System;
using System.Collections.Generic;
using System.Text;

namespace classTestet
{
    public class Character
    {
        private string name = "";
        private string title = "";
        public int atk;

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


    }
}
