using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren
{
    class Program
    {
        //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249434?start=0

        static void Main(string[] args)
        {
            int num1 = 5;
            int num3;
          
            //unäre Operatoren
            num3 = -num1; //man macht num3 zu den negativen wert von num1 
            //das geht auch mit +, wenn ein negativer wert/eingabe von num1 erwartet aber nicht gewünscht ist

            Console.WriteLine("num1 ist: " + num1); //ausgabe
            Console.WriteLine("num3 unär von num1 ist: " + num3); //ausgabe
            Console.WriteLine("");

            //sinvolle anwendung
            //Console.WriteLine("ist es sonnig? Bitte antworte mit True oder false");
            //string isSunny = Console.ReadLine(); //Usereingabe in Variable einlesen
            //bool issunny = bool.Parse(isSunny); //das ganze in ein bool wert konvertieren
            //Console.WriteLine("ist es snonig? (das Gegenteil mit ! der Usereingabe ("+isSunny+")= "+!issunny); //(alternativ geht unär auch mit dem zeichen ! -aber nur bei boolischen werten in der ausgabe!)
            //bool aussage = true;
            //Console.WriteLine("ist es snonig? (das Gegenteil mit ! vom festgelegten bool wert ("+aussage+")= " + !aussage);
            //Console.WriteLine("");

            //Inkrement
            int num2 = 3;
            Console.WriteLine("num 2 ist: "+num2);
            num2++; //das Inkrement, das 1 hochzählt
            Console.WriteLine("das inkrement (X++) von num2 ist: "+num2); //man kann nicht in der ausgabe inkrementieren, sonst müsssen wir pre inkrementieren
            Console.WriteLine("das inkrement (X++) von num2 in der Ausgabe ist (theoretisch num2 ("+num2+")+ 1): " + num2++);
            Console.WriteLine("warum? das Inkrement von num2 wurde zuerst um 1 erhöht, theoretisch soll das mit der");
            Console.WriteLine("Zeile jetzt wieder passieren, VS liest aber zuerst die (inkrementierte) Variable num2,");
            Console.WriteLine("erhöt aber erst DANACH!(Links nach rechts lesen...)");
            //man kann nicht in der ausgabe inkrementieren, sonst müssen wir pre inkrementieren
            //warum? er liest zuerst in der ausgabe das num2, DANN führt er das inkrement aus (links nach rechts lesen)
            Console.WriteLine("");

            //Preinkrement
            int num4 = 5;
            Console.WriteLine("num4 ist: " + num4);
            ++num4;
            Console.WriteLine("das Pre-inkrement (++X) von num4 ist: " + num4); //man kann nicht in der ausgabe inkrementieren, sonst müsssen wir pre inkrementieren
            Console.WriteLine("das Pre-inkrement (++X) von num4 in der Ausgabe ist (theoretisch num4 (" + num4 + ")+ 1): " + ++num4);
            Console.WriteLine("warum? das Pre-inkrement von num4 wurde ja logischerweise zuerst um 1 erhöht, DANN nochmal..");
            Console.WriteLine("");

            //Dekrement
            int num5 = 6;
            Console.WriteLine("num 5 ist: " + num5);
            num5--; //das Inkrement, das 1 hochzählt
            Console.WriteLine("das Dekrement (X--) von num5 ist: " + num5); //man kann nicht in der ausgabe dekrementieren, sonst müsssen wir pre dekrementieren
            Console.WriteLine("das Dekrement (X--) von num5 in der Ausgabe ist (theoretisch num5 (" + num5 + ")- 1): " + num5--);
            Console.WriteLine("warum? das Dekrement von num5 wurde zuerst um 1 verrinert, theoretisch soll das");
            Console.WriteLine(" mit der Zeile jetzt wieder passieren, VS liest aber zuerst die (inkrementierte) Variable num5,");
            Console.WriteLine(" verringert aber erst DANACH! (Links nach rechts lesen...)");
            //man kann nicht in der ausgabe dekrementieren, sonst müssen wir pre dekrementieren
            //warum? er liest zuerst in der ausgabe das num5, DANN führt er das Dekrement aus (links nach rechts lesen)
            Console.WriteLine("");

            //Predekrament
            int num6 = 9;
            Console.WriteLine("num6 ist: " + num6);
            --num6;
            Console.WriteLine("das Pre-dekrement (--X) von num6 ist: " + num6); //man kann nicht in der ausgabe dekrementieren, sonst müsssen wir pre inkrementieren
            Console.WriteLine("das Pre-dekrement (--X) von num6 in der Ausgabe ist (theoretisch num6 (" + num6 + ")- 1): " + --num6);
            Console.WriteLine("warum? das Pre-dekrement von num4 wurde ja logischerweise zuerst um 1 verringert, DANN nochmal..");
            Console.WriteLine("");

            //Grundrechenarten
            Console.WriteLine("für die Demonstration von Grundrechenarten, geben Sie bitte 2 Ganzzahlige (int) Zahlen ein:");
            Console.WriteLine("Die 1. Zahl (num7 bitte eingeben: ");
            string Num7 = Console.ReadLine();
            int num7 = int.Parse(Num7);
            Console.WriteLine("Die 2. Zahl bitte eingeben: ");
            string Num8 = Console.ReadLine();
            int num8 = int.Parse(Num8);
            Console.WriteLine("num7 ist: {0}; num8 ist: {1}",num7, num8);
            int result = num7 + num8; // die normale berechnung (Addition)
            Console.WriteLine("das ergebnis von num7 ({0}) + num8 ({1}) ist: {2}", num7, num8, result);
            result = num7 - num8; // die normale berechnung (Subtraktion)
            Console.WriteLine("das ergebnis von num7 ({0}) - num8 ({1}) ist: {2}", num7, num8, result);
            result = num7 * num8; // die normale berechnung (Multiplikation)
            Console.WriteLine("das ergebnis von num7 ({0}) * num8 ({1}) ist: {2}", num7, num8, result);

            double num9 = 1.0, num10 = 2.0;
            Console.WriteLine("num9 für die Division ist {0} (bei {0},0 die null weggelassen) und num10 ist {1} (bei {1},0 die null weggelassen)", num9, num10);
        //    double num7 = double.Parse(Num7); //2mal parsen geht nicht
            double resultDiv = num9 / num10; // die normale berechnung (Division) - doubles sind zur korrekten Berechnung nötig! ints sind zu ungenau/Ganzzahlig
            Console.WriteLine("das double ergebnis festgelegter double werte von num9 ({0}) / num10 ({1}) ist: {2}", num9, num10, resultDiv);

            int resultMod = num7 % num8; // die normale berechnung (Modolo - Rest der Division)
            Console.WriteLine("das ergebnis von num7 ({0}) % num8 ({1}) ist: {2}", num7, num8, resultMod);
            result = num7 / num8;
            Console.WriteLine("<-- warum? eine normale division {0}:{1} hat das int ergebnis {2}, Rest (=Modolo) {3}", num7, num8, result, resultMod);

            Console.ReadKey(); //pausiere...
        }
    }
}
