using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstanten
{
    // https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249406?start=0

    /* Konstanten sind normalerweise Felder, welche währende der Kompilierzeit bekannt ist und danach für die gesamte
     * Laufzeit des Programms nicht verändert werden können = sie bleiben konstant */

    class Program
    {
        //bei der Deklaration muss eine Konstante gleich mit initrialisiert werden.
        const double PI = 3.141523895;
        //man kann jetzt in allen Klassen auf diese Variable zugreifen, ähnlich einer globalen deklaration ausserhalb der funktion auf die alle
        //anderen Funktionen aufbauen können

        /*wollen wir das ganze nun sperren fürü beispielsweise andere Programmierer in einer TeamArbeit, kann man sich entweder gleich direkt an 
         * pullrequests in speziellen Codeverwaltungssoftwares für Teams bedienen oder man lagert es gleich seperat in einen anderen Projekt 
         * aus und bindet das Projekt nur also sigbnierte DLL Hier zur Verfügung */

        static void Main(string[] args)
        {
                        PI = 3.1; //das funktioniert so nicht, PI kann nicht verändert werden, es ist eine FESTE Variable
        }
    }
}
