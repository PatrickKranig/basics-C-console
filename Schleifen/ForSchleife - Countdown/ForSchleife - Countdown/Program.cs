using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSchleife___Countdown
{
    class Program

    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249488?start=15
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++) //code snippet for TABTAB
            { //Zählervariable; Überprüfung (wie oft), Zählervariable erhöhen/Verringen (/Inkremenieren/dekrementieren)
                Console.WriteLine("Countdown {0}", i); //Code
            }
            Console.ReadKey();
        }
    }
}
