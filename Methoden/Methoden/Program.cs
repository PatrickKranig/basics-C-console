using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249418?start=0
        //Die main Methode ist immer der 1. Startpunkt!
        //static = man braucht kein Objekt von Programm um aufgerufen zu werden
        static void Main(string[] args)
        {
            Console.WriteLine("Ich bin die Standard Main Methode");
            WriteSomething(); //Methode beim Einstiegspunkt des Programms aufrufen
            WriteSomethingSpecific("Argument für Methode WriteSomethingSpecific"); //"test" wird als Argument an die Methode übergeben und in selbiger in my Text
            /*wenn man in der Methode nun myText ausgibt, kommt das übergeben Argument || alternativ das kann man auch mit einer Variable machen
            wieso ist das nützlich? mal angenommen eine Methode berechnet das Ergebnis, eine andere Methode gibt aus, dann müssen wir
            ja das ergebnis irgenwie in die Methode rein bekommen (AppDomainManager spricht hier von Übergebn) */
            Console.ReadKey();
        }

        // Aufbau einer Methode
        //Zugriffsmodifizierer (static) Rückgabeteyp Methodennqame(Parameter1, Parameter2){Methodenrumpf}
        public /*Methode ist zugänglich von anderen Klassen aus*/ static void /*Rückgabetyp Leer*/ WriteSomething()
        {
            Console.WriteLine("ich bin die 2. Methode");
           //Liefert keinen Rückgabewert
        }

        public static void WriteSomethingSpecific(string myText) //der Parameter myText wurde in einen Atemzug gleich deklariert
        //wenn man static nicht hat, kann man es von der statischen Methode main nicht ausführen
        //myText kann man nun als Variable von überall verwenden
        {
        Console.WriteLine("Ausgabe des übergebenen Arguments von der 1. Methode: "+myText); //gibt entweder den Wert von myText (das Argument von oben) aus oder eben nicht
        //myText = "Hallo"; //Achtung, hiermit haben wir wieder das Argument/die Variable/MethodenParameter überschrieben!
            
        }

        //Das sind alles Methoden OHNE Rückgabewert (=void)
    }
}
