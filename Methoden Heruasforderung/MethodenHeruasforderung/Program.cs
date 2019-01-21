using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenHeruasforderung
{
    class Program
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249426?start=0
    {
        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Peter";
            string friend3 = "Herbert";

            Console.WriteLine("Freund1 in der MAIN Methode war: "+friend1);
            Console.WriteLine("");
            GreetFriend(friend1); //wir übergeb den Freund1 an die Methode

            Console.WriteLine("Freund2 in der MAIN Methode war: " + friend2);
            //warum führt er nicht gleich alles aus? mit "GreetFriend(...) wird die Methode zunächst aufgerufen und mit Console.ReadKey pausiert....
            Console.WriteLine("");
            GreetFriend(friend2);

            Console.WriteLine("Freund3 in der MAIN Methode war: " + friend3);
            Console.WriteLine("");
            GreetFriend(friend3);
            //Wir starten die Methode 3 mal, eine kleinere algorithmische alternative zu einer schleife etc.
        }
        static public void GreetFriend(string friendName) //void, weil wir nichts wieder zurückgeben wollen für die ausgabe da oben
            //wenn was zurügegeben werden soll, sperrt es automatisch die Ausgabe in der Metode und die Methode dien´t nur der Berechnung etc.
        {
            Console.WriteLine("[Methode FreetFriend] -> Hi "+friendName+", mein Freund!"); //Ausgabe des übergebenen Wertes
            //den Freund Namen aus der MAIN Methode könnten wir mit den übergebenden FrienNamé alternativ anzeigen lassen....
            Console.WriteLine("Drücke beliebige Taste um fortzufahren...");
            Console.WriteLine("");
            Console.ReadKey(); //alternativ kann man auch 3mal in der Main stoppen, so ersparen wir uns 3 Zeilen durch 1 ^^
        }
    }
}
