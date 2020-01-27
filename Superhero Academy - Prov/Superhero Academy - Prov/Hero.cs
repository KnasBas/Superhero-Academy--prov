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

        protected int strength = 0;     //
                                        //
        protected int intelligence = 0; //variablerna är protected för att kunna kommas åt inom subklasserna
                                        //
        protected int endurance = 0;    //

        protected static Random generator = new Random(); //slump generator

        private string classroom; //En private string eftersom ingen i main eller subklasserna behöver åtkomst för parametern, hittils

        public Hero()
        {
            List<string> classrooms = new List<string>() { "Te17A", "Te17B", "Te17C", "Te17D", "Te17E" }; //klassen kommer att slumpas två gånger som koden är uppbyggd nu (när subklassernas instans skapas), men detta märker inte spelaren av.
            classroom = classrooms[generator.Next(classrooms.Count)]; //jag vill att alla alternativ ska kunna slumpas därför använder jag .Count            
        }
        public void PrintStats() //En enkel metod för att skriva ut den randomiserade stats:en spelarens Hero har fått.
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Klass: " + classroom);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Intelligence: " + intelligence);
            Console.WriteLine("Endurance: " + endurance);
        }
    }
}
