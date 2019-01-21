using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249398?start=0

            //Wandle die Variable (Zahl) in einen Sting um
            int a = 3;
            string myZahlString = a.ToString();

            Console.WriteLine("der String der Zahl a ist: "+myZahlString);
            Console.WriteLine("Variable + String als String = "+myZahlString/*Zeichenkette*/+a/*Variable-Zahl*/);
            //er fügt nur der Zeichenkette was anderes hinzu = Concatination
            
            //um den String zu einen echten Zahlenwert zu machen und eine arithmetische Operation ausführen zu können, muss man parsen
            //parsen = maschinenlesbare Daten analysieren, segmentieren und codieren
            int num1 = int.Parse(myZahlString);
            int erg = num1 + a; //parsen, sonst können wir keine mathematischen methoden ausführen!
            //parsen zu Zahl funktioniert nur, wenn der String tatsächlich eindeutig ein Zahlenwert ist!
            Console.WriteLine("Variable a "+a+" + geparsten Sting "+myZahlString+" = "+erg);
            Console.ReadKey();
        }
    }
}
