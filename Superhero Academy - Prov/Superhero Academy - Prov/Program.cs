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
            Console.WriteLine("Välj vilken klass hen bör vara, 1 = Mutant, 2 = Alien, 3 = Regular"); //vilka val som finns
            string answer = Console.ReadLine();
            int choice = 0; //parameterns huvudfunktion är att jämföra spelarens alternativ med de giltiga
            bool heroclass = int.TryParse(answer, out choice); //TryParse för att checka den spelarens alternativ
            while (!heroclass && choice <= 0 || choice >= 4) //felsökning, while-loopen fortsätter tills du anger ett giltigt svar
            {
                Console.WriteLine("Ogiltigt svar!");
                answer = Console.ReadLine();
                heroclass = int.TryParse(answer, out choice);
            }

            switch(choice) //En simpel switch för att skriva ut alla olika scenarion för spelaren beroende på vilken typ av hero hen väljer att skapa.
            {
                case 1:
                    Mutant m1 = new Mutant(); //ny instans av den valda kategorin
                    m1.name = h1.name; //h1.name ger sin information över till den nya instansen
                    Console.WriteLine("Mutant");
                    m1.PrintStats();
                    break;

                case 2:
                    Alien a1 = new Alien(); //ny instans av den valda kategorin
                    a1.name = h1.name;
                    Console.WriteLine("Alien");
                    a1.PrintStats();
                    break;

                case 3:
                    Regular r1 = new Regular(); //ny instans av den valda kategorin
                    r1.name = h1.name;
                    Console.WriteLine("Regular");
                    r1.PrintStats();
                    break;

            }

            Console.ReadLine(); //Readline i slutet för att läsa av koden ovan.
        }
    }
}
