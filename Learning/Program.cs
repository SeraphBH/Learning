using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private string FormDuCadre1;
    private string FormDuCadre2;

    static void Main(string[] args)
    {
        Program myProgram = new Program();  // instance de programme permmetant de faire appel tout les tout les void publique
               
        myProgram.Initialisation();
        myProgram.GestionTouche();      
    }

    public void GestionTouche()
    {
        Program myProgram = new Program();

        bool maBoucle = true;
        while (maBoucle) // boucle permetant de lire les touches
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.F5:
                        myProgram.Initialisation();
                        //Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        myProgram.Date();
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        myProgram.Saisie();
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        myProgram.PlusMoins();
                        break;
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        myProgram.Voiture();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        int x = 3;
                        int y = 3;
                        Console.SetCursorPosition(x, y++);
                        Console.WriteLine("Erreur de saisie");
                        Thread.Sleep(400);
                        myProgram.Initialisation();
                        break;
                }
            }
        }
    }

    public void Initialisation()
    {
        Program myProgram = new Program();
        Console.Clear();
        myProgram.PersonalisationAleatoir();
        myProgram.CadreMenu();
        myProgram.MenuInteraction();

    }

    public void CadreMenu()
    {
        Console.WriteLine(this.FormDuCadre1);
        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine(this.FormDuCadre2);
        }
        Console.WriteLine(this.FormDuCadre1);
    }

    public void MenuInteraction()
    {
        int x = 3;
        int y = 2;

        Console.SetCursorPosition(x, y++);
        x += 3;
        Console.WriteLine("Menu de selection (utilisez le pavé numerique):");
        Console.SetCursorPosition(x, y++);
        Console.WriteLine("1- Date et jour");
        Console.SetCursorPosition(x, y++);
        Console.WriteLine("2- Saisie Touche");
        Console.SetCursorPosition(x, y++);
        Console.WriteLine("3- Jeux + ou -");
        Console.SetCursorPosition(x, y++);
        Console.WriteLine("4- Mini voiture");
    }

    public void PersonalisationAleatoir()
    {
        int maValeur = 0;

        for (int i = 1; i <= 5; i++)
        {
            maValeur = new Random().Next(1, 6);
        }
        switch (maValeur)
        {
            case 1:
                this.FormDuCadre1 = "*******************************************************";
                this.FormDuCadre2 = "*                                                     *";
                break;
            case 2:

                this.FormDuCadre1 = "-------------------------------------------------------";
                this.FormDuCadre2 = "-                                                     -";
                break;
            case 3:

                this.FormDuCadre1 = "#######################################################";
                this.FormDuCadre2 = "#                                                     #";
                break;
            case 4:

                this.FormDuCadre1 = "=======================================================";
                this.FormDuCadre2 = "|                                                     |";
                break;
            case 5:

                this.FormDuCadre1 = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
                this.FormDuCadre2 = "~                                                     ~";
                break;
        }
    }

    public void Saisie()
    {
        Program myProgram = new Program();

        ConsoleKeyInfo cki;
        // Prevent example from ending if CTL+C is pressed.
        Console.TreatControlCAsInput = true;
        // déclaration des variable pour position le curseur
        int x = 3;
        int y = 3;
        Console.SetCursorPosition(x, y++);// on execute la fonction puis on incremente y de +1
        Console.WriteLine("Les touches CTL, ALT, and SHIFT sont aussi accessibles.");
        Console.SetCursorPosition(x, y);
        Console.WriteLine("Appuyez sur Escape (Esc) pour quitter le programme \n");
        do
        {
            cki = Console.ReadKey();
            Console.Write(" --- Vous avez appuyé sur : ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            Console.WriteLine(cki.Key.ToString());
        } while (cki.Key != ConsoleKey.Escape);

        myProgram.Initialisation();

    }

    public void Voiture()
    {
        Program myProgram = new Program();
        Console.CursorVisible = false;

        Task.Run(() =>
        {
            while (true)
            {
                PlaySound();
            }
        });
               
        // variable pour le positionement de la voiture
        int x = 15;
        int y = 15;
        // variable pour suprimer les trainés de déplacement
        int x1 = 3;
        int y1 = 3;
        // variable  pour supriment le scintiment
        int a = 0;
        int b = 0;

        string maVoiture = "[]";
        string maCorrection = " ";        
               
        // creation du cadre pour la course
            Console.WriteLine("************************************************************");
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("*                                                          *");
        }
            Console.WriteLine("************************************************************");                
        
        // boucle while pour la saisie de touche 
        bool maBoucle = true;
        while (maBoucle) // boucle permetant de lire les touches
        {
            
            //Repositionement de la voiture en cas de hors cours
            if (x <= 0 || x >= 58 || y <= 0 || y >= 21)
            {
                x = 30;
                y = 10;
            }

            // La boucle if est necessaire pour suprimé le scintiment des lignes dynamique
            if (x != a || b != y)
            {
   
            //positionement de la voiture           
            Console.SetCursorPosition(x, y);
            Console.WriteLine(maVoiture);            
            Console.SetCursorPosition(x1, y1);
            Console.WriteLine(maCorrection);            

            // affiche x et y en bas à droite du cadre             
            Console.SetCursorPosition(50, 22);
            Console.WriteLine("x=" + x + " ");
            Console.SetCursorPosition(56, 22);
            Console.WriteLine("y=" + y + " ");
              a = x;
              b = y;
            }

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        x1 = x;
                        y = y - 1;
                        y1 = y + 1;
                        maCorrection = "  ";
                        break;
                    case ConsoleKey.DownArrow:
                        x1 = x;
                        y = y + 1;
                        y1 = y - 1;
                        maCorrection = "  ";
                        break;
                    case ConsoleKey.LeftArrow:
                        y1 = y;
                        x = x - 1;
                        x1 = x + 2;
                        maCorrection = " ";
                        if (x == 0)
                        {
                            x1 = 1;
                            maCorrection = "  ";
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        y1 = y;
                        x = x + 1;
                        x1 = x - 1;
                        maCorrection = " ";
                        if (x == 58) maCorrection = "  ";
                        break;
                    case ConsoleKey.Escape:
                        // quite la boucle while pour retourner au menu principal
                        maBoucle = false;
                        Console.CursorVisible = true;
                        break;
                    default:
                        // si le pilote saisie une autre touche que les flesh ou echap, crée un court message d'erreur
                        Console.Clear();
                        int e1 = 3;
                        int e2 = 3;
                        Console.SetCursorPosition(e1, e2);
                        Console.WriteLine("Erreur de saisie");
                        Thread.Sleep(500);
                        Console.SetCursorPosition(e1, e2);
                        Console.Clear();
                        
                            Console.WriteLine("************************************************************");
                        for (int i = 1; i <= 20; i++)
                        {
                            Console.WriteLine("*                                                          *");
                        }
                            Console.WriteLine("************************************************************");
                            //positionement de la voiture           
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine(maVoiture);
                            Console.SetCursorPosition(x1, y1);
                            Console.WriteLine(maCorrection);

                            // affiche x et y en bas à droite du cadre             
                            Console.SetCursorPosition(50, 22);
                            Console.WriteLine("x=" + x + " ");
                            Console.SetCursorPosition(56, 22);
                            Console.WriteLine("y=" + y + " ");
   
                        break;
                }
            }
        }        
        myProgram.Initialisation();

    }

    public void Date()
    {
        Program myProgram = new Program();

        // Petit code pour faire 2 operation en meme temps

        Parallel.Invoke(
            () =>
            {
                Console.WriteLine("Premiere Opération en cours :");
                Thread.Sleep(4000);
                Console.WriteLine("Opération 1 Terminé!");
            },
            () =>
                {
                Console.WriteLine("2eme Opération en cours :");
                Thread.Sleep(2000);
                Console.WriteLine("Opération 2 Terminé!");
                }            
            );

        
        DateTime thisDate1 = DateTime.Now;
        Console.WriteLine("Nous somme le " + thisDate1.ToString("MMMM dd, yyyy") + ".");
        string mois = thisDate1.ToString("MMMM");

        Console.WriteLine(DateTime.Now);
        System.DateTime moment = DateTime.Now;
                
        int year = moment.Year;
        Console.WriteLine(year);

        int month = moment.Month;
        Console.WriteLine(month);

        int day = moment.Day;
        Console.WriteLine(day);

        int hour = moment.Hour;
        Console.WriteLine(hour);

        int minute = moment.Minute;
        Console.WriteLine(minute);

        int second = moment.Second;
        Console.WriteLine(second);

        int millisecond = moment.Millisecond;
        Console.WriteLine(millisecond);

        switch (mois)
        {
            case "mars":
            case "avril":
            case "Mai":
                Console.WriteLine("C'est le printemps.");
                break;
            case "juin":
            case "juillet":
            case "aout":
                Console.WriteLine("C'est l'été.");
                break;
            case "septembre":
            case "octobre":
            case "novembre":
                Console.WriteLine("C'est l'automne.");
                break;
            case "décembre":
            case "janvier":
            case "février":
                Console.WriteLine("C'est l'hiver.");
                break;
        }
    }


    public void PlusMoins()

    {
        Program myProgram = new Program();
        Console.Clear();
        Console.WriteLine("************************************************************");
               
        bool reboot = false;
        int Devine = 10;        
        int NombreEssai = 7;

        for (int truerand = 1; truerand <= 5; truerand++)
        {
            Devine = new Random().Next(1, 100);
        }

        bool maBoucle1 = true;
        while (maBoucle1)
        {
            reboot = true;
            // Vérification du nombre de chance et quitte la boucle si = 0
            if ( NombreEssai == 0 )
            {
                Console.WriteLine("Vous Avez perdu!!");
                Thread.Sleep(2000);
                Console.Clear();
                break;

            }

            Console.WriteLine("Taper un chiffre entre 1 et 100");
            Console.WriteLine("Il vous reste " + NombreEssai + " chance!!");
	        string line = Console.ReadLine(); 
	        int Valeur ;
	        if (int.TryParse(line, out Valeur))
	        {
                if (Valeur > Devine)
                {
                    Console.WriteLine("Trop grand");
                }
                if (Valeur < Devine)
                {
                    Console.WriteLine("Trop Petit");
                }
                if (Valeur == Devine)
                {
                    Console.WriteLine("Bravo vous avez gagnié alors qu'il vous restait " + --NombreEssai + " Chance!!");
                    Thread.Sleep(2000);
                    reboot = false;
                    break;
                }

	        }
	        else
	        {
	        Console.WriteLine("Ce n'est pas un nombre");
            Console.WriteLine("Nous allons reprendre le jeu au début!");
            Thread.Sleep(1000);
            break; 
	        }

            NombreEssai--;
        }
        if (reboot == true)
        {
            myProgram.PlusMoins();
        } 
        else
        {
            myProgram.Initialisation();
        }
        
    }

    static void PlaySound()
    {
        const int soundLenght = 100;
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(990, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1188, soundLenght * 2);
        Console.Beep(1320, soundLenght);
        Console.Beep(1188, soundLenght);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(990, soundLenght * 2);
        Console.Beep(880, soundLenght * 4);
        Console.Beep(880, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1188, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(990, soundLenght * 6);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1188, soundLenght * 4);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1056, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Thread.Sleep(soundLenght * 2);
        Console.Beep(1188, soundLenght * 4);
        Console.Beep(1408, soundLenght * 2);
        Console.Beep(1760, soundLenght * 4);
        Console.Beep(1584, soundLenght * 2);
        Console.Beep(1408, soundLenght * 2);
        Console.Beep(1320, soundLenght * 6);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1188, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(990, soundLenght * 4);
        Console.Beep(990, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1188, soundLenght * 4);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1056, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Thread.Sleep(soundLenght * 4);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(990, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1188, soundLenght * 2);
        Console.Beep(1320, soundLenght);
        Console.Beep(1188, soundLenght);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(990, soundLenght * 2);
        Console.Beep(880, soundLenght * 4);
        Console.Beep(880, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1188, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(990, soundLenght * 6);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1188, soundLenght * 4);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1056, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Thread.Sleep(soundLenght * 2);
        Console.Beep(1188, soundLenght * 4);
        Console.Beep(1408, soundLenght * 2);
        Console.Beep(1760, soundLenght * 4);
        Console.Beep(1584, soundLenght * 2);
        Console.Beep(1408, soundLenght * 2);
        Console.Beep(1320, soundLenght * 6);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1188, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(990, soundLenght * 4);
        Console.Beep(990, soundLenght * 2);
        Console.Beep(1056, soundLenght * 2);
        Console.Beep(1188, soundLenght * 4);
        Console.Beep(1320, soundLenght * 4);
        Console.Beep(1056, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Console.Beep(880, soundLenght * 4);
        Thread.Sleep(soundLenght * 4);
        Console.Beep(660, soundLenght * 8);
        Console.Beep(528, soundLenght * 8);
        Console.Beep(594, soundLenght * 8);
        Console.Beep(495, soundLenght * 8);
        Console.Beep(528, soundLenght * 8);
        Console.Beep(440, soundLenght * 8);
        Console.Beep(419, soundLenght * 8);
        Console.Beep(495, soundLenght * 8);
        Console.Beep(660, soundLenght * 8);
        Console.Beep(528, soundLenght * 8);
        Console.Beep(594, soundLenght * 8);
        Console.Beep(495, soundLenght * 8);
        Console.Beep(528, soundLenght * 4);
        Console.Beep(660, soundLenght * 4);
        Console.Beep(880, soundLenght * 8);
        Console.Beep(838, soundLenght * 16);
        Console.Beep(660, soundLenght * 8);
        Console.Beep(528, soundLenght * 8);
        Console.Beep(594, soundLenght * 8);
        Console.Beep(495, soundLenght * 8);
        Console.Beep(528, soundLenght * 8);
        Console.Beep(440, soundLenght * 8);
        Console.Beep(419, soundLenght * 8);
        Console.Beep(495, soundLenght * 8);
        Console.Beep(660, soundLenght * 8);
        Console.Beep(528, soundLenght * 8);
        Console.Beep(594, soundLenght * 8);
        Console.Beep(495, soundLenght * 8);
        Console.Beep(528, soundLenght * 4);
        Console.Beep(660, soundLenght * 4);
        Console.Beep(880, soundLenght * 8);
        Console.Beep(838, soundLenght * 16);
    }

}