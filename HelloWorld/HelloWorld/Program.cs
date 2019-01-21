//einzeilige Kommentare werden mit // davor geschrieben

using System; //Wir verwenden das Namespace von System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//Wir verwenden das Namespace von System

namespace HelloWorld //der Name unseres Projekt - eine Art Paket, in der unser Code geschrieben wird
{
    class Program //eine Klasse ermöglicht es uns bestimmten Code auszuführen und wir können da davon Objekte erstellen
    {

        // https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249362?start=0

        static void Main(string[] args) //Die Main Methode ist der 1. Einstiegspunkt des Programms
                                        //static = man muss von dieser Klasse kein Objekt erstellen um es verwenden zu können
                                        //void = ohne Rückgabewert ; in () sind die Parameter angegeben
        {
            Console.ForegroundColor = ConsoleColor.Green; //ändert die Konsolenschriftfarbe auf Grün

            /* Auf Hierarchie achten! d.h. das Programm führt den Code von Oben nach unten aus, das ändern der Schriftfarbe 
             * würde nach der Ausgabe keinen Sinn ergeben */
             // /* sind mehrzeilige Kommentare, mit */ wieder schließen
             // Kommentare sind sinnvoll für die Dokumentation/nachvollziehbarkeit

            Console.WriteLine("Hello World!"); //einfach "HelloWorld" ausgeben (aber ohne Unterbrechung, d.h. wir sehen die ausgabe net)
            Console.ReadKey(); //wartet auf Eingabe um Code fortzuführen (sinnvoll um den User Zeit zu geben, die Ausgabe zu lesen)
            

        }
                //Body = Codeblock/Codekörper = das was zwischen den {} steht
    }
}
