using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeherAbfangen_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein die durch 0 geteilt werden soll");
            string zahl1 = Console.ReadLine();
            try
            {
                int Zahl1 = int.Parse(zahl1);
                int erg = Zahl1 / 0; //das hier löst den Fehler aus, daher wird die nächste Zeile schon gar nicht mehr versucht
                Console.WriteLine("die Division durch 0 ist: " + erg);
            }
            catch (DivideByZeroException) //wir haben das DivideByZeroException bgefangen
            {
                Console.WriteLine("Man kann nicht durch 0 teilen! Warst du schonmal in der Schule? ");
            }
            catch (Exception) //da kommen alle Fehler rein, die wir nicht wissen bzw. wir nicht klar deklarieren können um sie abzufangen
            {
                Console.WriteLine("Grundlegender Fehler");
            }
     //     Console.WriteLine("die Division durch 0 ist: " + erg); //diese Zeile geht nicht, weil die Variable erg NUR in den try block ist, nirgens anders!

            Console.ReadKey();

        }
    }
}
