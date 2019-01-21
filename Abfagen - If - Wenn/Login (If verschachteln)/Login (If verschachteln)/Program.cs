using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login__If_verschachteln_
{
    class Program
        /* Gefahren von goto!
           In Assembler ist es üblich, Schleifen und manchmal sogar auch Funktionsaufrufe durch goto zu ersetzen. Diese Praxis hat man teils nach C übertragen.
           Es wurde nicht mit Labels gespart und selbst wenn ein Programmierer Funktionen nutzte, kam es vor, dass dort auch Labels gesetzt wurden und das Programm 
           zwischen verschiedenen Funktionen springen konnte. 
           Das führte dazu, dass Quelltexte irgendwann selbst für den Programmierer nicht nachvollziehbar waren. Auch heute kommt es noch vor, dass vor allem Anfänger,
           die z.B. Probleme mit Schleifen haben, derartige Methoden anwenden. Das ist definitiv ein schlechter, wenn nicht sogar der schlechteste Programmierstil.

           Schleifen haben den Vorteil, dass alle Anweisungen in einem Block und die Ausdrücke im Kopf, bzw. Fuß zusammengefasst sind. Das erhöht die Übersicht. 
           So etwas fehlt in einer goto-Schleife. Werden viele Sprungmarken eingesetzt, gibt es zum einen Probleme diese zu finden. Es ist einfach nur zu aufwändig,
           einen langen Code, nach einem bestimmten Label abzusuchen und sobald man sich mit einem Label vertan hat, sind Fehler nur noch sehr aufwendig zu finden.
           Kommt kurz nach einem Label eine weitere Sprunganweisung, ist der Verlauf eines Programms schwer nachzuvollziehen. Schlecht benannte Labels sorgen ebenfalls dafür, 
           dass man den Verlauf des Programms nur schwer nachvollziehen kann. Möchte man einen solchen Quelltext nach einer längeren Zeit nochmals überarbeiten,
           so ist es effektiver, diesen neu zu schreiben.*/
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte gebe einen Benutzernamen ein du Schwachmat:");
            string benutzer = Console.ReadLine();
            Console.WriteLine("bitte gebe jetz ein Passwort ein für das Dreckskonto:");
            string pw = Console.ReadLine();
            Console.WriteLine("Danke!");
            Console.ReadKey();
        nochmal:
            Console.Clear();
            Console.WriteLine("Bitte geb für den Login deinen Benutzernamen ein du Trottel:");
            if (benutzer == Console.ReadLine())
            {
                Console.WriteLine("Hallo " + benutzer+" Drücke eine beliebige Taste und gib das Passwort ein du Penis:");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Jetzt gib endlich das PW ein du hoden:");
                if (pw == Console.ReadLine())
                {
                    Console.WriteLine("Super, du bist eingeloggt!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("das war das falsche pw du krüppel, versuche es nochmal!");
                    Console.ReadKey();
                    goto nochmal;
                }
            }
            else
            {
                Console.WriteLine("was kannst du eigentlich?? NOCHMAL!");
                Console.ReadKey();
                goto nochmal;
            }

            Console.ReadKey();
            // //Andere Möglichkeit:
            //static void Main(string[] args)
            //{
            //    Register(); //Methode aufrufen
            //    Login();
            //    Console.ReadKey();
            //}
            //static public void Register() //Methode muss Static sein um sie von der static main methode aufrufen zu können
            //{
            //    //Methode zum registrieren - das Speichern funktioniert nur während der Laufzeit, nach Néustart sind die Variablen/Werte gelöscht
            //    Console.WriteLine("Bitte trage deinen Benutzernamen ein:");
            //    username = Console.ReadLine();
            //    Console.WriteLine("Bitte gib dein Passwort an: ");
            //    password = Console.ReadLine();
            //    Console.WriteLine("Registrierung erfolgreich!");
            //    Console.WriteLine("-----------------------------------------------------");
            //}
            //public static void Login()
            //{
            //    Console.WriteLine("Benutzername eingeben: ");
            //    if (username == Console.ReadLine())
            //    {
            //        Console.WriteLine("Bitte gib dein Passwort ein!");
            //        if (password == Console.ReadLine())
            //        {
            //            Console.WriteLine("Login erfolgreich!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Das PW war falsch du klappspaten");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Benutztername existiert nicht");
            //    }



            } 
    }
}
