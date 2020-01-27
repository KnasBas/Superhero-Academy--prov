using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy___Prov
{
    class Regular : Hero
    {
        public Regular()
        {
            intelligence = generator.Next(5, 10);
            strength = generator.Next(1, 7); //olika stats beroende på vilken hero man väljer
            endurance = generator.Next(7, 10);
        }

    }
}
