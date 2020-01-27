using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy___Prov
{
    class Alien : Hero
    {
        public Alien()
        {
            intelligence = generator.Next(1, 6);
            strength = generator.Next(8, 9); //olika stats beroende på vilken hero man väljer
            endurance = generator.Next(9,12);
        }
    }
}
