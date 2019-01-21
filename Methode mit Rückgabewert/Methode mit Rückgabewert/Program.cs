using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_mit_Rückgabewert
{
    class Program
    {
        // https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249420?start=0
        static void Main(string[] args)
        {
            //Add(); //Eine Methode mit zu übergebenen Parametern kann man nicht "einfach aufrufen" ohne Argummente zu übergeben (initialisieren)

            //2 Argumente für die Methode übergeben/initialisieren und das Ergebnis der arithmetischen Berechnung von return in result speichern:
            int result = Add(5/*für num1*/, 8/*für num2*/); //die Argumente (wie externes initialisieren) an die Methode übergeben und in selbiger in num1 und num2 einsetzen
            /*wenn man in der Methode nun num1/num2 ausgibt, kommt das übergeben Argument || alternativ das kann man auch mit einer Variable machen
            wieso ist das nützlich? mal angenommen eine Methode berechnet das Ergebnis, eine andere Methode gibt aus, dann müssen wir
            ja das ergebnis irgenwie in die Methode rein bekommen (AppDomainManager spricht hier von Übergebn) */

            Console.WriteLine("die summe der mit 'return' übergebenen int Variable (der Berechnung von num1+num2) in result ist= "+result); //Ausgabe des gespeicherten Wertes der Methode Add
            //alternativ statt "result" kann man auch gleich die Add Methode mit Parameter in die Console schreiben (dann haben wir auch den zurückgegebenen wert von int)
            //-> dann brauchen wir natürlich dementsprechend das result mit dem obrigen Add(...) nicht mehr

            //Mann kann auch was ganz verrücktest machen -> die add methode addiert ja richtig? was wäre wenn wir immer andere zahlen angeben und berechnen lassen?
            Console.WriteLine("");
            Console.WriteLine("wir lassen das ergebnis 2er ergebnisse 2er Add Methoden in 1 Add Methode anzeigen:");
            Console.WriteLine(Add(Add(9, 1), Add(21, 9))); //das ergebnis ist rein theoretisch 40
            Console.ReadKey();
        }
        public static int /*statt void=leer, ich will ein int zurückgeben */ Add(int num1, int num2) //wir übergeben num1 und num2 als Variablen an die methode
        {
            return num1 + num2; //return = Rückgabewert, in dem Falle eine arithmetische Berechnung aus num1 und num2
            //Die werte für num1 und num2 kann man nicht in der Methode initialisieren, es muss extern oben als argument übergeben werden (ich habe es getestet...)
            /*return gibt etwas zurück (in dem falle die summe von num1 und num2 in "int" (oben)*/

            //wir haben hier einen Algoritmus geschaffen, der einfach 2 Zahlen addiert!

            //alternativ kann man noch eine Variable dazwischenschieben
            //int result = num1 + num2; //der code geht auch
            //return result; //der code geht auch
            // macht sinn für größere Projekte wenn noch viel mehr in der Methode passieren soll und man nicht gleich mit return das ergebnis ermitteln lassen will
        }
      
    }
}
