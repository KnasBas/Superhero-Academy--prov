using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy___Prov
{
    class Hero
    {
        public string name; //public för att Main ska kunna förändra variabeln

        protected int strength = 0;

        protected int intelligence = 0; //variablerna är protected för att kunna kommas åt inom subklasserna

        protected int endurance = 0;

        protected static Random generator = new Random(); //slum generator

        public Hero() //en konstruktor
        {
        }

        public void PrintStats()
        {
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Endurance: " + endurance);
        }
    }
}
