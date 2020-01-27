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

        protected string classroom;

        private int i = 0;

        public Hero()
        {
            List<string> classrooms = new List<string>() { "Te17A", "Te17B", "Te17C", "Te17D", "Te17E" };
            classroom = classrooms[generator.Next(classrooms.Count + 1)]; //plus 1 eftersom att jag vill att alla alternativ ska kunna slumpas

        }
        public void PrintStats()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Endurance: " + endurance);
        }
    }
}
