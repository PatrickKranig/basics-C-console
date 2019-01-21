using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenutzerEingaben
{
    class Program
    {
        static void Main(string[] args)
        {
            //Benutzereingabe wird in einer string Variable gespeichert
            Console.WriteLine("Bitte etwas eingeben:");
            string input = Console.ReadLine();

            Console.WriteLine("Die Benutzereingabe war: {0}", input); //Ausgabe
            Console.ReadKey();
        }
    }
}
