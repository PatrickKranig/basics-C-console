using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenVererbung

//https://www.youtube.com/watch?v=Rjnal5Wt5LI&list=PLeuqVJR_UVPjaz1iSJWAR8-SlrJ4WEFUl&index=20
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund dog = new Hund();

            //Zugriff auf Member der Klasse "Hund"
            dog.NameHund = "Coco";
            dog.Bellen();

            //Zugriff auf vererbten Member der Klasse "Tier"
            dog.Geschlecht = "Rüde"; //die eigentliche Geschlecht eigenschaft ist ja garnicht in der Klasse Hund enthalten, aber in Tier
            dog.Bewegen();
        }
    }
    class Tier
    {
        //Eigenschaften
        public string Geschlecht { get; set; }

        //Methoden
        public void Bewegen()
        {
        }
    }
    class Hund : Tier //mit : geben wir die Verervung der Eigenschaften und Methoden von Tier an
    { 
        //Eigensschaften
        public string NameHund { get; set; }

        //Methoden...
        public void Schnüffeln()
        {

        }
        public void Bellen()
        {

        }
    }
}
