using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    //https://www.youtube.com/watch?v=-O9R80Nrj_4&list=PL_pqkvxZ6ho18awjThtUMZio-yvc79TGi&index=6
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249496?start=6
    class Program
    {
        static void Main(string[] args)
        {
            //Der Codeblock der Schleife wird mindestens 1mal durchlaufen auch wenn später die bedingung falsch ist (bei der while wird ja sofort abgefrage
            // und eventuell nicht durchlaufen
            Console.WriteLine("Bitte gib eine Ganzzahlige Zahl (a) für den Countdown Start ein");
            string A = Console.ReadLine();
            int a = int.Parse(A); // der Countdown startet hier
            int a_eingabe = +a; //Code zum zusätzlichen speichern der ursprünglich eingegebenen Zahl
            Console.WriteLine("");

            Console.WriteLine("Bitte gib eine Ganzzahlige Zahl ein (x), bis wann der Countdown gehen soll");
            string B = Console.ReadLine();
            int x = int.Parse(B);
            //das snippet ist do TABTAB
            do
            {
                Console.WriteLine("Durchlauf der Schleife = Countdown Nummer  {0}", a);
                a++; //die schleifenveriable muss für die endlichkeit des programms erhöht werden
            }
            while (a <= x); //Solange a kleiner als x ist, führe die Schleife x-mal aus (z.b. wenn a 0 ist und x 5, dann stimmt das und die schleife durchläuft 5mal
                               //wenn a 7 und x 3, ist es false und es wird nix durlaufern
                               //Wenn True, dann füre die Schleife nochmal aus, wenn FALSE, dann durchlaufe keine schleife
            if (a_eingabe >= x) //Fehlerauswurf, wenn schleife nicht durchlaufen wird ... wenn immer true "oder (true)" dann endlosschleife
            {
                Console.WriteLine("Fehler: Das Schleifenende muss nach dem Schleifenanfang kommen");
                Console.WriteLine("Schleife wurde nicht durlaufen, aber wegen Do While nur 1mal durchlaufen!");
            }

            Console.ReadKey(); //Fazit, While prüft ERST, wenn zutrifft durchläuft er schleife, wenn nicht dann nicht
                               //DoWhile Prüft DANACH, wenn danach zutrifft, springt er raus, wenn nicht führt er schleife nochmal aus
                               // -> wenn es also nicht zutrifft, dann macht er nicht nichts, er durchläuft trotzdem MINDESTENS 1mal die schleife
                               // -> "Rumpfgesteuerte schleife
            }
    }
}
