using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden_und_eigene_Klassen
{
    // https://www.youtube.com/watch?v=PhvjwmkVEfg&list=PLeuqVJR_UVPjaz1iSJWAR8-SlrJ4WEFUl&index=17
    class Program
    {
        static void Main(string[] args)
        {
            Mensch coco = new Mensch(); //Objekt instanziieren

            coco.Name = "coco"; //wird zwar von der methode in der Klasse gebraucht, braucht man aber nicht zwinglich (dann wird der Name einfach leer gelassen)
            coco.Begrueßung(); //rufe diese Methode auf

            Console.ReadKey(); //stoppt konsole wieder
        }
    }
    class Mensch
    {
        //Eigenschaften
        public int Alter { set; get; } //Eigenschaft Alter setzen
        public string Name { set; get; } //Eigenschaft Name setzen

        //Methoden
        public void Begrueßung() //kann nur in diesen Objekt aufgerunfen werdenn  bzw. wenn was v0on den datentyp des objektes Mensch ist
        { //Methodenkörper
            Console.WriteLine(Name + " sagt Hallo");
        }
    }
}
