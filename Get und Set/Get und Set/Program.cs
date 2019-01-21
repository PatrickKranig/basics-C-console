using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_und_Set
{
    //https://www.youtube.com/watch?v=qXj4B4l92_A
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm Start = MAIN Methode");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Klasse Hendrik vom Typ Person deklarieren (intanziieren)");
            Person hendrik = new Person();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("hendrik den wert 10 zuweisen (set):");
            hendrik.Alter = 10; //set methode, zum setzen
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Jetzt kommt die Ausgabe von hendrik.Alter (get- holen):");
            Console.WriteLine(hendrik.Alter ); //get methode, zum holen
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("sinn? wir können nicht auf die private Variable der Klasse Person zugreifen, nur eben über die Eigenschaft x.Alter -> sehr sauberer und sicherer Porgammierstil");
            Console.ReadKey();

            /*Der Unterschied liegt in der Datenkapselung begründet. Ich habe dazu mal etwas vorbereitet ;-) https://www.lernmoment.de/alle/was-ist-datenkapselung/ 
             * Wenn du eine Eigenschaft verwendest hast du später noch die Chance beim Setzen oder Auslesen des Wertes gewisse Bedingungen zu prüfen o.ä. Grundsätzlich
             * empfehle ich immer ein Attribut NICHT public zu machen! Der Kerngedanke von OO ist, dass du Methoden in einer Klasse hast die die Attribute verändern. 
             * Lässt du die Attribute von ausserhalb der Klasse verändern, dass weisst du einerseits nicht was alles reinkommt und andererseits hast du deine Datenkapselung
             * wesentlich verwässert. Es geht schließlich immer darum, dass du eine Verantwortung in deiner Klasse umsetzt und niemand ausserhalb deiner Klasse wissen muss
             * wie du das umgesetzt hast. Eine andere Erklärung: http://www.inf-schule.de/modellierung/ooppython/roboter/datenkapselung/konzept_datenkapselung */

        }
    }
    class Person
    {
        //Private Variablen
        private int PrivateVariable;

        //Eigenschaften (händisch get und set)
        public int Alter //das get, set schreiben wir jetzt mal verdeutlicht ausführlich rein, eigentlich reicht nur:
                         //public int Alter {get; set;}
                         //<- wenn wir das so machen, wird automatisch eine "unsichtbare" private variable "alter" für diese Klasse deklariert
        {
            get
            {
                Console.WriteLine("Ausgabe, dass die Get Methode ausgeführt wird: Alter wurde eingelesen"); //zur verdeutlichung
                return PrivateVariable; //Gebe den Wert der Privaten Variable den wir nur in der Klasse benutzen dürfen als Eigeschaftswert für die Instanzierung (OOP) zurück
                //Private Varialble ist noch 0, da wir nur "Getten" - holen/lesen
            }
            set
            {
                Console.WriteLine("Ausgabe, dass die Set Methode ausgeführt wird: Alter wird neu geschrieben");//zur verdeutlichung
                PrivateVariable = value; //value (wert) ist das Schlüsselwort für den Zuweisungswert (variabel je nach Objekt/Code)
            }//(wie rum, ist egal)
        }
    }
}
