using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenutzerEingabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib die 1. Ganzzahlige Zahl ein:");
            string zahl1 = Console.ReadLine(); //speichere die UserEingabe in eine Variable zahl1
            double num1 = double.Parse(zahl1); //wandle den Userinput (string) in eine Zahl um, mit der wir rechnen können
            Console.WriteLine("Bitte gib die 2. Ganzzahlige Zahl ein: ");
            string zahl2 = Console.ReadLine(); //speichere die UserEingabe in eine Variable zahl2
            double num2 = double.Parse(zahl2); //wandle den Userinput (string) in eine Zahl um, mit der wir rechnen können

            double erg = num1 + num2; //die Berechnung der geparsten Zahlen

            Console.WriteLine("das ergebnis von "+zahl1+" und "+zahl2+" ist= "+erg); //gebe alle werte aus!
            Console.WriteLine("");
            Console.WriteLine("mit beliebiger Eingabe beenden...");
            Console.ReadKey(); //pausiert das ganze wieder

            //Alternativ kann man das (einlesen) und berechnen in einer extra methode machen oder statt Zahlen, kommazahlen (double + pparsen) berechnen lassen

        }
    }
}
