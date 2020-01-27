using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy___Prov
{
    class Mutant : Hero
    {
        public Mutant()
        {
            intelligence = generator.Next(5, 11);
            strength = generator.Next(8, 11); //olika stats beroende på vilken hero man väljer
            endurance = generator.Next(2, 8);
        }
    }
}
