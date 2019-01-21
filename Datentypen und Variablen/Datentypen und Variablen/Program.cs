using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen_und_Variablen
{
    class Program //Klassennamen in 1 String ohne Leerzeichen schreiben, zur besseren Lesbarkeit Camelcase Verfahren z.b. ClientActivity
                  // http://www.datenbanken-verstehen.de/namenskonventionen-datenbank/camel-case-notation/
                  // https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249368?start=0
                  // https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249370?start=0
    {
        //selbiges für Methode, muss nicht, ist aber sinnvoll
        static void Main(string[] args)
        {
            int /* Festlegung des Datentypes  */ wert1 /*deklaration/anlegen/festlegen der Variable */ = 25; /* + Initialisierung/Wertzuweisung */
            int wert2; //Deklariert
            //Deklaration mehrerer Variablen:
            int wert3, wert4, wert5; //Variablen sind aber leer
            wert2 = 15; //Initalisierung
            int summe /*Deklaration einer Summen Variable*/ = wert1 + wert2; //Initialisierung der summe mit einer arithemtischer Berechnung

            double d1 = 3.5; //Kommazahlen deklarieren - Verwendung von Gleitkommazahlen mit double, Double hat nur Insgesamt 16 Zeichen!
            double d2 = 1.337;
            double ergebnis = d1 / d2;

            float f1 = 1.337f; //das F Hinter der Float Zahl ist wichtig und begründet eine Zuweisung einer Floatzahl statt eines angeommenen Doubles
            float f2 = 3.444f;
            float f3 = f1 * f2;
            //Genauigkeit 7 Stellen - geringerer Speicherplatz

            string meinName = "Patrick";
            int LängeDesStrings = meinName.Length;
            string AllesGross = meinName.ToUpper(); //mit () muss man Méthoden wie meinName.ToUpper aufrufen
            // meinName.ToLower für kleingeschrieben
                 
            Console.WriteLine(summe); //Ausgabe der Variable Summe   
            //Ausgabe der Zahlen
            Console.WriteLine("die Summe ist von (int) wert1+wert2: " + summe); //concatination/Verkettung von mehreren Werten zu einen längeren String
            Console.WriteLine("double 1= "+d1);
            Console.WriteLine("double 2= " + d2);
            Console.WriteLine("Das Ergebnis von (double) d1 und d2 ist: " + ergebnis); //Berechnung von Kommazahlen
            Console.WriteLine("Das Produkt von (float) f1 und f2 ist: " + f3);
            Console.WriteLine("float 1= " + f1);
            Console.WriteLine("float 2= " + f2);
            Console.WriteLine(""); //Leerzeile
            Console.WriteLine("Mein name ist " + meinName + " (der Name ist {0} Zeichen lang)", LängeDesStrings); //String ausgeben + Verkettung der Länge
            Console.WriteLine("Mein name ist " + AllesGross + " (alles wurde großgeschrieben)"); //String ausgeben in Großschrift
            /*was ist das {0} in den String? Es ´zeigtauf die Übergebende Variable an 0. Stelle, in dem Fall LängeDesStrings
             * (wenn mehr mit , angegeben, dann eben 1 usw.)*/
            Console.ReadKey();


        }
    }
}
