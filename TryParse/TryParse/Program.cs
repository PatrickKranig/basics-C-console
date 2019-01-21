using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        /*für demonstration nehmen wir das IF Konstrukt: 
        https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249440?start=30
        https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249442?start=195 (effizienter) [hier wird auch das TryParse errklärt*/
        static void Main(string[] args)
        {
            Console.WriteLine("wie warm schätzt du ist es momentan? Gib eine Ganze Zahl (in Grad) an:");
            string TemperatureInput = Console.ReadLine(); //Eingabe (immer) als string
            //int temperature = int.Parse(Temperature); //den string umwandeln in einer Zahl mit der wir arbeiten können

            int temperature;
            int number;  //das wird unsere TryParse Ausgabevariable
            //TryParse tut eig das gleiche wie die TryCatch Funktion, allerdings fängt es gleichzeitig den potentiellen fehler ab

           // bool UserEnteredANumber = int.TryParse(TemperatureInput, out number); //Alternativ geht es auch mit dem hier 
            //-> wir speichern das als true/false wert in eine bool Variable

            if (int.TryParse(TemperatureInput, out number)) //hat das TryParse funktioniert? out ist die Variable die ausgegeben  werden soll, falls der PARSE funktioniert hat
                //wenn wir mit dem alternativen bool arbeiten wollen, müssen wir dementsprechend die bool Variable in die Bedingung überpüfen lassen
            {
                temperature = number; // hat das funktioniert?- dann speichere in temperature den geparsten wert des strings in denwert number
            }
            else
            {
                temperature = -888; //wenn e snicht erfolgreich war, dann speichere den wert -888
                //wenn wir das hier nicht haben, erwartet das folgende programm einen wert um weiter atrbeiten zu können und abfragen zu können
                //denn mit den TryParse probieren wir es nur, können aber nicht garantieren dass es klappt... dann wäre temperature nicht zugewiesen
            }
            //Vorteil/Unterschied zu der TryCatchFinally? wir müssen bei TryParse nicht alle möglichen Fehler zur genauen Deklaration coden und gestalten das hier ein wenig übersichlicher
           Console.WriteLine("");

            if (temperature == -888) //Bedingung überprüfen
            {
                Console.WriteLine("1. Abfrage = Konvertierungsfehler! Zahl zu groß oder Eingabe ist keine Zahl oder Eingabe Leer oder sonstiges"); //Wenn zweig 
                //das Try Parse hat nicht geklappt (ich habe dementsprechend mal als >Variable temperature auf utopische -888 gelegt
                Console.WriteLine("Du solltest eine Ganze Zahl (ohme Komma) eingeben du honk!"); //Spaß :)
            }
            else if (temperature == 15) //Prüfe im selben CodeBlock eine 2. Anweisung im sonst zweig der 1. abfrage
            {
                Console.WriteLine("2. Abfrage im 1. SONST Zweig = es ist genau 15°C, Optimal!");
                Console.WriteLine("Der User hat {0}°C eingegeben", temperature); //Ausgabe, was der nutzer eingegeben hat (Kontrollmechanismus)
            }
            else if (temperature > 15) //Prüfe im selben CodeBlock eine 3. Anweisung im sonst zweig der 2. abfrage
            {
                Console.WriteLine("3. Abfrage im 2. SONST Zweig = es ist eine Bullen Hitze!", temperature);
                Console.WriteLine("Der User hat {0}°C eingegeben", temperature); //Ausgabe, was der nutzer eingegeben hat (Kontrollmechanismus)
            }
            else if (temperature  < 15) //Prüfe im selben CodeBlock eine 4. Anweisung im sonst zweig der 3. abfrage
            {
                Console.WriteLine("4.Abfrage im 3. SONST Zweig= zieh deine jacke an, es ist unter 15°C kalt - es ist etwas frischlich/kalt!");
                Console.WriteLine("Der User hat {0}°C eingegeben", temperature); //Ausgabe, was der nutzer eingegeben hat (Kontrollmechanismus)
            }
            else //das wird ausgeführt, wenn keine bedigung von oben zutrifft "Sonst zweig) - um was unvorhergesehendes festzulegen
            {
                Console.WriteLine("4. endlicher SONST Zweig= - alle anderen Abfragen treffen NICHT Zu (wie auch immer)");
            }
            Console.WriteLine("");
            Console.WriteLine("Beenden mit beliebiger Taste...");
            Console.ReadKey(); //Pausiere die Konsole wieder

            //der Code ist effizienter und benötigt weniger Rechenleistunmg anstatt immer und immer wieder EXTRA abzufragen, so fragen wir nur 2mal (trotzdem mehrere male) ab
        }
    }

}

