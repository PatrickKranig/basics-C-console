using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Bedingungen
{
    class Program
    {
        //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249440?start=30
        //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249442?start=195 (effizienter)
        static void Main(string[] args)
        {
            Console.WriteLine("wie warm schätzt du ist es momentan? Gib eine Zahl (in Grad) an:");
            string Temperature = Console.ReadLine(); //Eingabe (immer) als string
            int temperature = int.Parse(Temperature); //den string umwandeln in einer Zahl mit der wir arbeiten können
            Console.WriteLine("");

            if (temperature < 15) /*Bedingung überprüfen - vereinfacht gesagt, fragenn wir was ab, 
                ob diese Bedingung in Klammern zutrifft (true/false) ((boolscheVariable(n)))*/
            {
                Console.WriteLine("1. Abfrage = zieh deine jacke an, es ist unter 15°C kalt- es ist etwas frischlich!"); //Wenn zweig     
            }
            else if (temperature == 15) //Prüfe im selben CodeBlock eine 2. Anweisung im sonst zweig der 1. abfrage
            {
                Console.WriteLine("2. Abfrage im 1. SONST Zweig = es ist genau 15°C, Optimal!");
            }
            else if (temperature > 30) //Prüfe im selben CodeBlock eine 3. Anweisung im sonst zweig der 2. abfrage
            {
                Console.WriteLine("3. Abfrage im 2. SONST Zweig = es ist eine Bullen Hitze!");
            }
            else //das wird ausgeführt, wenn keine bedigung von oben zutrifft "Sonst zweig) - um was unvorhergesehendes festzulegen
            //das letzte SONST des 3. Zweiges - das endliche!
            {
                Console.WriteLine("3. endlicher SONST Zweig= Zwischen 21 und 30 Grad- alle anderen Abfragen treffen NICHT Zu");
            }
            Console.WriteLine("");
            Console.WriteLine("Beenden mit beliebiger Taste...");
            Console.ReadKey(); //Pausiere wieder
            //der Code ist effizienter und benötigt weniger Rechenleistunmg anstatt immer und immer wieder EXTRA abzufragen, so fragen wir nur 2mal (trotzdem mehrere male) ab
        }
    }
}
