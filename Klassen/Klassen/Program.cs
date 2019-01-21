using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    //https://www.youtube.com/watch?v=40hQ6FnqRSI&list=PL_pqkvxZ6ho18awjThtUMZio-yvc79TGi&index=14
    //https://www.youtube.com/watch?v=puf8z--uDp8&index=15&list=PL_pqkvxZ6ho18awjThtUMZio-yvc79TGi Eigenschaften...
    class Program //Wir haben eine neue Klasse erstellt, mit der wir arbeiten können
    {
        class Person //erstelle eine ganz neue Klassen (wie Console oder sonst was)
        {
            //Eigenschaften setzen - sie beschreiben eine Klasse/Objekt - das sind keine Variablen!!!
            //- sie sind ein Konstrukt aus 2 Methoden (get und set) und einer privaten veriable
            public string Name { get; set; } //public ist der zugriffsmodifizierer, zum festlegen dass man auf die Eigenschaft von außen zugreifen darf
            //wenn wir public weglassen, wird es automatisch als private gewertet!
            public int Alter { get; set; } //es gibt nur 4 zugriffsmodifizierer public, protected, internal, private
                                           //Zugrfiffsmodifizierer: https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/keywords/access-modifiers

//was ist der unterschied zu get und set?
/* Der Unterschied ist der, dass du eine private Variable mit einer Eigenschaft kapselst. Das bedeutet, 
 * dass der Zugriff auf die private Variable über die Eigenschaft kontrolliert erfolgt. Du kannst im Getter 
 * und im Setter beispielsweise Abfragen machen und den Zugriff an bestimmte Bedingungen knüpfen. So ist es zum 
 * Beispiel möglich, dass du im Setter nur bei bestimmten Bedingungen wirklich eine Zuweisung auf die private Variable 
 * ermöglichst. Bei einer einfachen Variable ist das nicht möglich! :)*/
  //get damit wir aus der Klasse die Eigenschaft lesen können, set damit wir aus der Klasse die Eigenschaft lesen können

  private bool tot2; //Diese Variable zählt nur für diese Klasse
  public bool tot; //Diese Variable ost von außen ausserhalb der Klasse aufrufbar


  //Methoden schreiben
  public void SageHallo()
  {
      Console.WriteLine(Name + " sagt Hallo!");
  }
}

  static void Main(string[] args) //Einsteigspunkt für das Programm
  {
     //Objekt vom Typ Person erstellen ( Person ist jetzt ein Datentyp)
     Person janek = new Person(); //in janek steckt die Objektinstqanz von Person - Objekt instanzieieren

     janek.Name = "Janek"; //Definition eines Objektes (set Methode)
     janek.SageHallo(); //führe nun diese Methode der neuen Klassse aus - das ganze spart code und macht es übersichtlicher beim coden

     Console.WriteLine("");
     Console.WriteLine("jetzt habe ich ein ganz neues Objekt 'Hendrik' erstellt!"); //(mit neuen Eigenschaften)
     Console.WriteLine("");

     Person hendrik = new Person(); //Hendrik ist nur die Variable vom Typ (der Klasse) Person

     hendrik.Name = "Hendrick"; //Hendrik ist ein ganz neues Objekt!
     int alter = hendrik.Alter = 22; //lege die Initialisierung der Eigesnschaft auf eine Variable
         //wenn wir das ganze über die get methode bei der ausgabe laufen lassen wollen, brauchen wir keine variable
     Console.WriteLine("Hendrik ist {0} Jahre alt", alter);
     //Console.WriteLine("Hendrik ist {0} Jahre alt", hendrik.Alter); //alternativ auch möglich: wir nuten die implementierte get methode
     hendrik.tot = true; //Arbeiten mit KlassenVariablen - tot2 ist nicht initialisierbar, weil private
     Console.WriteLine("ist hendrick tot? " + hendrik.tot + " (natürlich nicht, mir fiel nur schnell nix ein =P");
     hendrik.SageHallo();

     Console.ReadKey();

  //das ganze ist Objektorientierte Programmierung (OOP)
  //. ist der c# standard Operator für Eigenschaften
  }


}
}


