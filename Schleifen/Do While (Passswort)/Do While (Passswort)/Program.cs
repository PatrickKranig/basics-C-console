using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While__Passswort_
{
    class Program
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249496?start=195
    {
        static void Main(string[] args)
        {
            int LenghofPassword = 0; //setze die anfangs PW Länge auf 0

            do
            {
                Console.WriteLine("Bitte geben sie ein Passwort mit mindestens 6 zeichen ein:");
                string Password = Console.ReadLine(); //speicher die Eingabe in  eine Varialble
                LenghofPassword = 0; //setze die anfangs PW Länge immer wieder auf 0 zum anfang der schleife/eingabe
                int CurrentLength = Password.Length; //Zähle die länge und speichere das in eine variable
                LenghofPassword += CurrentLength;
                if (LenghofPassword <= 5)
                { //Hinweis, das der Mutzer weiss was er falsch gemacht hat
                    Console.WriteLine("ich habe gesagt, das password muss mindestens 6 zeichen lang sein du trottel");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (LenghofPassword <= 5);
            //Jetzt durchläuft (/prüft) die schleife solange, bis das PW mindestens 6 zeichen hat!
            
            Console.WriteLine("Danke das reicht su spast!");
            //Achtung, gucke das Udemy Video für ein anderes Programm mit unterschiedlichen Eingaben
            Console.Read();
        }
    }
}
