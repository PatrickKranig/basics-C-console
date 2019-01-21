using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSchleife
{
    class Program
    {
        //https://www.youtube.com/watch?v=poOdKu9qBz4&index=7&list=PL_pqkvxZ6ho18awjThtUMZio-yvc79TGi
        static void Main(string[] args)
        {
            Anfang: //<- bezeichnet jetzt den Anfang, Einstiegspunkt für das spätere goto
            Console.WriteLine("Die FOR Schleife beginnt mit der Zählvariable 0)");
            Console.WriteLine("");
            Console.WriteLine("Bitte gib die 1. Zahl (b) ein, wie oft die schleife durchlaufen werden soll:");
            string B = Console.ReadLine();
            
            try
            {
                int b = int.Parse(B); /*Probiere zu Parsen, wenn Runetime Error, 
                dann stürze nicht ab sondern lass den fehler mit catch abfangen...*/
            }
            catch (FormatException) //Fehler abfangen, wenn Eingabe keine Zahl ist (Format falsch)
            {
                Console.WriteLine("FEHLER! FormatException: Format war inkorrekt! Du hättest eine Nummer eintippen sollen!");
                Console.WriteLine("Mit Beliebiger Taste beenden...");
                Console.ReadKey(); 
                Environment.Exit(0); //bei Fehler beendet er alles
            }
            catch (ArgumentNullException) //Fehler abfangen, wenn Eingabe LEER ist (NULL)
            {
                Console.WriteLine("FEHLER! ArgumentNullException: Die Eingabe darf nicht Leer [NULL] sein!");
                Console.ReadKey();
                Console.WriteLine("Mit Beliebiger Taste beenden...");
                Console.ReadKey();
                Environment.Exit(0); //bei Fehler beendet er alles
            }
            catch (OverflowException) //Fehler abfangen, wenn Eingabe zu groß (overflow) ist
            {
                Console.WriteLine("FEHLER! OverflowException: der eingegebene Wert war zu lang!");
                Console.ReadKey();
                Console.WriteLine("Mit Beliebiger Taste beenden...");
                Console.ReadKey();
                Environment.Exit(0); //bei Fehler beendet er alles
            }
            catch (Exception) //da kommen alle Fehler rein, die wir nicht wissen bzw. wir nicht klar deklarieren können um sie abzufangen
            {
                Console.WriteLine("Grundlegender Fehler");
                Console.ReadKey();
                Console.WriteLine("Mit Beliebiger Taste beenden...");
                Console.ReadKey();
                Environment.Exit(0); //bei Fehler beendet er alles
            }
            int rightParsing = int.Parse(B); //jetz wissen wir ja, dass das parsen geht, daher können wir es hier richtig!
          

            for (int a = 0; a < rightParsing; a++) //wenn die mittlere Bedingung true, dann durchlaufe
            { //das snippet für for ist for TABTAB
                Console.WriteLine("Zählervariable a ist momentan {0}, Bedingung ob weiter durchlaufen werden soll b = {1} nach a < b", a, rightParsing);
            }
            if (rightParsing == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Fehler, die Eingabe war die Zählervariable, bitte versuche es erneut:");
                Console.WriteLine("");
                goto Anfang; //Springt wieder zum Anfang
            }
            //Mit der For - Schleife kann man zum Beispiel sehr gut eine Datenstruktur wie einen Array mit Werten befüllen bzw. Werte daraus lesen. :)﻿

            Console.WriteLine("Mit beliebiger Taste beenden...");
            Console.ReadKey();
        }
    }
}
