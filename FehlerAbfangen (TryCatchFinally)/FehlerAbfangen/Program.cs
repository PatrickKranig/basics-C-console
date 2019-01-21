using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FehlerAbfangen
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249432?start=0
            //"TryCatchingFinally" (wörtlich: Versuchen Sie es endlich zu fangen"
            Anfang: //Einstiegspunkt für goto
            Console.WriteLine("Bitte trage eine Zahl ein:");
            string UserInput = Console.ReadLine();
            try
            {
                int userInput = int.Parse(UserInput); /*Probiere den Code auszuführen, wenn Runetime Error, 
                dann stürze nicht ab sondern lass den fehler mit catch abfangen...*/
            }
            catch (FormatException) //Fehler abfangen, wenn Eingabe keine Zahl ist (Format falsch)
            {
                Console.WriteLine("FEHLER! FormatException: Format war inkorrekt! Du hättest eine Nummer eintippen sollen!");
                Console.WriteLine("Versuche es nochmal...");
                goto Anfang;
            }
            catch (ArgumentNullException) //Fehler abfangen, wenn Eingabe LEER ist (NULL)
            {
                Console.WriteLine("FEHLER! ArgumentNullException: Die Eingabe darf nicht Leer [NULL] sein!");
            }
            catch (OverflowException) //Fehler abfangen, wenn Eingabe zu groß (overflow) ist
            {
                Console.WriteLine("FEHLER! OverflowException: der eingegebene Wert war zu lang!");
            }
            catch (Exception) //da kommen alle Fehler rein, die wir nicht wissen bzw. wir nicht klar deklarieren können um sie abzufangen
            {
                Console.WriteLine("Grundlegender Fehler");
            }
            //finally //Dieser Zweig wird immer ausgeführt ungeachtet dessen ob ein Fehler Auftritt oder nicht, man kann es natürlich weglassen
            //{
            //    /*wieso ist das sinnvoll? bei Datenbanken oder Datein schreiben o.ä. MUSS Die datei so oder so immer geschlossen werden
            //    oder hier rein kommt Code, den wir sowieso ausführen wollten... (wenn Fehler, was wir natürlich nicht wissen, wird alles
            //    nach dem TryCatch usw NICHT ausgeführt, und das wollen wir bei wichtigen Code natürlich nicht) */
            //    Console.WriteLine("Ich werde sowieso ausgeführt!");
            //}
                   
            Console.WriteLine("ERFOLGREICH! der Userinput war: "+ UserInput);
            Console.ReadKey();
        }
    }
}
