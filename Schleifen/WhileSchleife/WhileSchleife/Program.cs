using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSchleife
{
    class Program
    //https://www.youtube.com/watch?v=-O9R80Nrj_4
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249500?start=0
    //Kopfgesteuerte Schleife
    {
        static void Main(string[] args)
        {
            int a = 0; // der Countdown startet hier

            Console.WriteLine("Bitte gib eine Ganzzahlige Zahl ein, bis wann der Countdown gehen soll");
            string B = Console.ReadLine();
            int x = int.Parse(B);
            while (a < x) //Solange a kleiner als x ist, führe die Schleife x-mal aus
            {
                a++; //die schleifenveriable muss für die endlichkeit des programms erhöht werden
                Console.WriteLine("Countdown Nummer  {0}", a);
                
            }
            Console.ReadKey();
        }
    }
}
