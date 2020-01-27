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

        protected int intelligence = 0;

        protected int endurance = 0;

        public Hero() //en konstruktor
        {
        }
    }
}
