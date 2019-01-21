using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implizite_u_Explizite_Konvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249392?start=360

            //Implizite Konvertierung
            int num = 123456; //int ist 32bit groß
            long bigNum = num; //long ist 64 bit groß
                                   //Konvertierung geht - warum? int (32) ist kleiner als long (64) [Mouseover über Datentyp] -> kleineres passt logischerweise in größeres
            Console.WriteLine("int wert: " + num);
            Console.WriteLine("implizit konvertierter long wert aus int: " + bigNum);
            /*
             * long bigNum2 = 234453;
             * int num2 = bigNum2;     //geht logischerweise (groß in klein) nicht 
             */

            float myFloat = 13.37f;
            double myDouble = myFloat; //Funktioniert weil kleiner (Float) in groß (double)
                                       // andersrum geht net...
            Console.WriteLine("float wert: " + myFloat);
            Console.WriteLine("implizit konvertierter double wert aus int: " + myDouble);

            //Explizite Konvertierung
            int myInt; //int t nur Ganzzahlen
            double myNewDouble = 13.37; //Double Kommazahlen (Eselsbrücke: Double für 2; X.X (2 Variablen- mindestens1 vor und nach Komma= also mindestens2)
                                        //-> Umwandlung fehlt
                                        //myInt = myNewDouble -> geht nicht!
            myInt = (int)myNewDouble; //geht! mit (int) konvertiert er in Int, da Int aber nur Ganzzahlen darstellen kann, schneidet er einfach den Schwanz von Double ab und gibt alles vor dem Komma aus
            Console.WriteLine("int wert: " + myInt);
            Console.WriteLine("explizit konvertierter double wert aus int: " + myNewDouble);

            //Aus Zahlenwert String machen:
            string myString = myDouble.ToString(); //Ungenauigkeit der Zahl bei impliziter Konvertierung
            string myString2 = myNewDouble.ToString(); //Ungenauigkeit der Zahl bei impliziter Konvertierung
            Console.WriteLine("Zahlenwert (implizit) in String konvertiert: "+myString);
            Console.WriteLine("Zahlenwert (Explizit) in String konvertiert: " + myString2);
            //Beachte immernoch, dass es sich um ein String handelt! bei addieren giubt es keine arithmetische operation sondern eine einfache Verkettung
            //simple Datentypen kann man immer in Strings konvertieren! geht auch füür bool werte

            //(ist nützlich um logisch zu verfolgen, wie das programm arbeitet!)

            //mit STRG+K + STRG+C kann man automatisch makierte Blöcke auskommentieren
            //mit STRG+K + STRG+U kann man das ganze wieder aufheben
            //mit F5 startet man das Programm, mit STRG+F5 beendet man es wieder



            Console.ReadKey();
            }
    }
}
