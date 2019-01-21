using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class Program

    // https://www.youtube.com/watch?v=US4VDVnudD8&index=5&list=PLeuqVJR_UVPjaz1iSJWAR8-SlrJ4WEFUl
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249456?start=16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte geben sie eine Ganzzahlige Zahl zwischen 1-9 ein");
            string A = Console.ReadLine(); //einlesen kann man nur strings, der rechner weiss ja nicht, dass du eine zahl eingeben willst und wirst
            int a = int.Parse(A); //konvertierung des strings in eine Zahl für das SwitchCase
            switch (a) //Abfragen sind nicht möglich, ausser es ist ein boolischer Wert False/True
                //Code Snippet: sw TABTAB
            {
                //Fälle, was wäre wenn (quasi wie if)
                case 1:
                    Console.WriteLine("Ausgabe case 1: a ist 1");
                    break;
                case 2:
                    Console.WriteLine("Ausgabe case 2: a ist 2");
                        break;
                case 3:
                    Console.WriteLine("Ausgabe case 3: a ist 3");
                    break;
                case 4:
                    Console.WriteLine("Ausgabe case 4: a ist 4");
                    break;
                case 5:
                    Console.WriteLine("Ausgabe case 5: a ist 5");
                    break;
                case 6: //wenn wir break weglassen, wird einfach Fall 6,7,8,9 auf 9 bezogen (also weiter)
                case 7: //das ganze geht auch für strings case "..."
                case 8:
                case 9: Console.WriteLine("case 6-9: a ist 6 oder 7 oder 8 oder 9");
                    break;
                //wie Else in einer IF Bedingung
                default:
                    Console.WriteLine("Ausgabe default: Du solltest eine Zahl von 1 bis 9 eingeben!");
                    break;
            }
     
            Console.WriteLine("");
            Console.WriteLine("Drücken sie eine beliebige Taste zum beenden");
            Console.ReadKey();
        }
    }
}
