using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighScore
{
    //https://www.udemy.com/die-komplette-csharp-masterclass/learn/v4/t/lecture/10249452?start=498
    class Program
    {

        /*Erstelle eine Anwendung mit einem Score, Highscore und einem HighscorePlayer.
        Erstelle eine Methode, die zwei Parameter hat, einen für die Punktzahl und einen für den Spielernamen.
        Wann immer diese Methode aufgerufen wird, sollte überprüft werden, ob die Punktzahl des Spielers höher ist als die des Highscores, wenn ja, "Neuer highscore ist + " score" und in einer anderen Zeile "Neuer Rekordhalter ist " + playerName - auf die Konsole geschrieben werden, falls nicht "Der alte highscore von " + highscore + " konnte nicht gebrochen werden und wird immer noch gehalten von " + highscorePlayer.
        Überlege auch, welche Variablen außerhalb der Methoden und welche innerhalb der Methoden benötigt werden.*/

        //Höchste Punktzahl
        static int highscore = 300;
        //Benutzername - static, damit es in einer static Methdoe verwendet werden kann
        static string username;
        //Passeort - static, damit es in einer static Methdoe verwendet werden kann
        static string password;
        //Rejordhalterr
        static string highscorePlayer = "Denis";

        static void Main(string[] args) //Einsprungspunkt
        {
            Console.WriteLine("Zuerst einmal, registriere dich du lappen:");
            Register();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Jetzt musst du dich einloggen du mutti:");
            Login();
            anfang:
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Jetzt prüfen wir, ob dein highscore tatsächlich höher ist als der deiner Mutter du Hurensohn");
            int userScore = SetzeHighscore(username);
            CheckHighscore(userScore, username);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("willst du es nochmal du kacklappen?");
            if(Console.ReadLine() == "ja")
            {
                goto anfang; //Zeilensprungmarke     
            }

            
            Console.ReadKey();
        }

        static public int SetzeHighscore(string username)
        {
        Console.WriteLine("jetzt setzen wir mal einen theoretischen highscore für {0}", username);
            Console.WriteLine("Spieli Spiele, Eingabe:");
            string userscore = Console.ReadLine();
            int Userscore = int.Parse(userscore); //umwandeln der string eingabe in eine Zahl
        Console.WriteLine();
            return Userscore; //gibt schlussendlich den Wert "Userscore" für die Funktion zurück, für die sie da ist
         }

        static public void Register() //Methode muss Static sein um sie von der static main methode aufrufen zu können
        {
            Console.WriteLine("Bitte trage deinen Benutzernamen ein:");
            username = Console.ReadLine();
            Console.WriteLine("Bitte gib dein Passwort an: ");
            password = Console.ReadLine();
            Console.WriteLine("Registrierung erfolgreich!");
        }
        public static void Login()
        {
            nochmalBenutzerName:
            Console.WriteLine("Benutzername eingeben: ");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Bitte gib dein Passwort ein!");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login erfolgreich!");
                }
                else
                {
                    Console.WriteLine("Das PW war falsch du klappspaten. Starte Loginversuch neu wegen deiner Unfähigkeit");
                    goto nochmalBenutzerName;
                }
            }
            else
            {
                Console.WriteLine("Benutztername existiert nicht, los nochma du lappen");
                goto nochmalBenutzerName;
            }
        }

            public static void CheckHighscore(int score, string player)
            {
                if(score > highscore)
            {
                highscore = score;
                highscorePlayer = player;
                Console.WriteLine("neuer Highscore ist {0}", score);
                Console.WriteLine("neuer Rekordhalter ist {0}", player);
            }
            else
            {
                Console.WriteLine("DU KANNST NICHTS! der alter Highscore konnte nicht gebrochen werden. Es ist immer noch "+
                    "{0} und wird von {1} gehalten", highscore, highscorePlayer);
            }
        }
    }
}
