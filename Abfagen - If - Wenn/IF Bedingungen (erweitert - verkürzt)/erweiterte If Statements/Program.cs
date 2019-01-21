using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erweiterte_If_Statements
{
    class Program

    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249466?start=0

    /* Bedingung ? erster_Ausdruck : zweiter_Ausdruck;
     Bedingung muss entweder wahr oder falsch sein (true/false)
     Der konditionelle Operator ist rechtdassociativ
     Der AusdruckA ? b : c ? d : e
     wird so evaluiert a ? b : (c ? d : e),
     und nicht (a ? b : c) ? d : e.
     der Konditionelle Operator kann nicht überschrieben werden */
    {
        static void Main(string[] args)
        {
            int temperature = -5; //davon sind alle abfragen abhängig, man könnte das auch mit einer Usereingabe + Parse koppeln, macht mir aber jetzt zuviel arbeit :D

            string StateOfMatter;
            Console.WriteLine("Die Wassertemperatur beträgt {0}", temperature);
            if(temperature < 0)
            {
                StateOfMatter = "fest";
            }
            else
            {
                StateOfMatter = "flüssig";
            }
            Console.WriteLine("der Aggregatzustand von Wasser ist {0}, weil Gefrierpunkt ist bei 0°C", StateOfMatter);

            //Advanced If Statment
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Jetzt das ganze als Advanced If Statement");
            Console.WriteLine("-------------------------------------");

            //Zur Veranschaulichung wurde das < umgedreht
            StateOfMatter = temperature > 0 ? "fest": "flüssig";  //StateOfMatter setzen auf = Abfrage > 0 (?) DANN X SONST (:) Y

            Console.WriteLine("der Aggregatzustand von Wasser ist {0}, weil Gefrierpunkt ist bei 0°C", StateOfMatter);

            //jetzt das ganze für gasförmig...
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Jetzt das ganze theoretisch um die übber 100 != Gasförmig abzudecken:");
            StateOfMatter = temperature > 100 ? "gas" : (temperature < 0 ? "fest" : "flüssig");
            Console.WriteLine(StateOfMatter);
            //auf Deutsch: setze StateOfMatter auf Abfrage Temperatur über  100 DANN Gas sonst (erneute abfrage: temperatur <0 DANN fest SONST flüssig) 
            //übber 100 = gas ; unter 0 = fest, dazwischen flüssig
            Console.ReadKey();

        }
    }
}
