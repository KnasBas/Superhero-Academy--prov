using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy___Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h1 = new Hero(); //en ny instans
            Console.Write("Döp din hero: ");
            h1.name = Console.ReadLine();
            Console.WriteLine("Välj vilken klass hen bör vara, 1 = Mutant, 2 = Alien, 3 = Regular");
            string answer = Console.ReadLine();
            int choice = 0;
            bool heroclass = int.TryParse(answer, out choice);
            while (!heroclass || choice <= 0 && choice >= 4) //felsökning
            {
                answer = Console.ReadLine();
                heroclass = int.TryParse(answer, out choice);
            }

            switch(choice) //En simpel switch för att skriva ut alla olika scenarion för spelaren beroende på vilken typ av hero hen väljer att skapa.
            {
                case 1:
                    Mutant m1 = new Mutant();
                    Console.WriteLine("Mutant");
                    m1.PrintStats();
                    break;

                case 2:
                    Alien a1 = new Alien();
                    Console.WriteLine("Alien");
                    a1.PrintStats();
                    break;

                case 3:
                    Regular r1 = new Regular();
                    Console.WriteLine("Regular");
                    r1.PrintStats();
                    break;

            }

            Console.ReadLine();
        }
    }
}
