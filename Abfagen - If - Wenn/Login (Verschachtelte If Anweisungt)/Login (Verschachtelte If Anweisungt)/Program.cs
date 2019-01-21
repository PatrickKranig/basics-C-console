using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login__Verschachtelte_If_Anweisungt_
{
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249446?start=15
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistred = true;
            string UserName = "";
            Console.WriteLine("Bitte trage deinen Benutzernamen ein!");
            UserName = Console.ReadLine();

            if (UserName == "")
            {
                Console.WriteLine("du sollst was eingeben du trottel");
            }
            else if (UserName == "admin") //alternativ geht es auch mit UserName.equals("...")
            {
                Console.WriteLine("Hi admin!");
            }
            else if (UserName == "pat")
            {
                Console.WriteLine("hallo pat!");
            }
            else if (UserName != "")
            {
                Console.WriteLine("{0} du bist nicht registriert du spaten!", UserName);
            }
            Console.ReadKey();
            /*Theoretisch kann man eine Datenbank in den hintergrund schreiebn/laufen lassen, für die registrierten User
             * und kann sie an Variablen knüpfen, umn das ganze effektiver zu gestalten =) */
        }
    }
}
