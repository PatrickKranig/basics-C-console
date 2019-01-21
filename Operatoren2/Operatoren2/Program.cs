using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren2
{
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249434?start=0 Fortsetzung ca. minute11
    class Program
    {
        static void Main(string[] args)
        {
            //Relationale (Verhätnis) und Typoperatoren
            Console.WriteLine("Bitte geben  sie 2 Ganzzahlige (int) Zahlen ein");
            Console.WriteLine("Bitte geben sie die 1. Zahl (num1) ein:");
            string Num1 = Console.ReadLine();
            int num1 = int.Parse(Num1);
            Console.WriteLine("Bitte geben sie die 2. Zahl (num2) ein:");
            string Num2 = Console.ReadLine();
            int num2 = int.Parse(Num2);
            bool islower = num1 < num2; //Relation (/Verhältnisse) kann man effektiv nur mit bool werten darstellen
            Console.WriteLine("das Verhältinis(Relation) von num1 ({0}) < num2 ({1}) ist {2}", num1, num2, islower);
            islower = num1 > num2; //Relation (/Verhältnisse) kann man effektiv nur mit bool werten darstellen
            Console.WriteLine("das Verhältinis(Relation) von num1 ({0}) > num2 ({1}) ist {2}", num1, num2, islower);

            //Gleichheitsoperatoren
            bool isEqual = num1 == num2; //ist das GLEICH? Gleichheitsoperatoren  kann man effektiv nur mit bool werten darstellen [equal -> Gleich)
            Console.WriteLine("der Gleichheitsoperator von num1 ({0}) == num2 ({1}) ist {2}", num1, num2, isEqual);
            isEqual = num1 != num2; //Ungleich 
            Console.WriteLine("der Gleichheitsoperator von num1 ({0}) != (Ungleich) num2 ({1}) ist {2}", num1, num2, isEqual);

            //Konditionelle Operatoren (oder logische Verknüpfung)
            bool isLowerAndEqual;
            //Kondition 1 UND Kondition2
            isLowerAndEqual = islower && isEqual;
            Console.WriteLine("der Konditionelle Operator von "+num1+">"+num2+"(="+islower+") && (und) "+num1+"!="+num2+"(="+isEqual+") ist {0}",  isLowerAndEqual);
            //Kondition1 ODER Kondition2 (Mindestens 1 muss JA)
            isLowerAndEqual = islower || isEqual;
            Console.WriteLine("der Konditionelle Operator von " + num1 + ">" + num2 + "(=" + islower + ") || (Oder) " + num1 + "!=" + num2 + "(=" + isEqual + ") ist {0}", isLowerAndEqual);
            //sicher gibt es noch viele weitere, das hier ist denke ich aber aussreichend ;)
            Console.ReadKey();
        }
    }
}
