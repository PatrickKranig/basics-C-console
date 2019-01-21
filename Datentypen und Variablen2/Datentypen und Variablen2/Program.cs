using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentypen_und_Variablen2
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249404?start=0
            //Tabelle: https://docs.microsoft.com/de-de/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)
            byte myByte = 25; //0-255
            Console.WriteLine("myByte: "+myByte);
            sbyte mySbyte = 15; //-128-127
            Console.WriteLine("mySbyte: "+mySbyte);
            int myInt = 12318925; //-2mrd-2mrd
            Console.WriteLine("myInt: "+myInt);
            uint myUint = 123091; //4,3mrd
            Console.WriteLine("myUint: "+myUint);
            short myShort = -32768; //niedrigster wert
            Console.WriteLine("myShort: "+myShort);
            ushort myUShort = 65535; //kann nur positive werte haben
            Console.WriteLine("myUShort: "+myUShort);
            float myFloat = -31.1289f; //kann negative und positive werte haben
            Console.WriteLine("myFloat: "+myFloat);
            double myDouble = -12.1231250;
            Console.WriteLine("myDouble: "+myDouble);
            char myCharacter = 'A';
            Console.WriteLine("myCharacter: "+myCharacter);
            bool myBool = true;
            Console.WriteLine("myBool: "+myBool);
            string myText = "I control text";
            Console.WriteLine("myText: "+myText);
            string numText = "15";
            Console.WriteLine("numText vor dem parsen: "+numText);

            //int b = 15;  
            //int erg = numText + b; <- geht nicht, da NumText immernoch ein String ist

            int myNumFromText = int.Parse(numText); //der String numText wurde als Zahl geparst
            Console.WriteLine("numText nach dem parsen: " + myNumFromText);
            
            int b = 15;
            int erg = myNumFromText + b; //mit der geparsten Zahl von NumText können wir nun arithmetische Berechnungen durchführen
            Console.WriteLine("gebe das Ergebnis der geparsten NumText Variable in einer arithmetischen Berechnung aus= "+erg);

            Console.ReadKey();

        }
    }
}
