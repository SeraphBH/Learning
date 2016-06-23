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
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        myProgram.Saisie();
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

        // variable pour le positionement de la voiture
        int x = 15;
        int y = 15;
        // variable pour suprimer les trainés de déplacement
        int x1;
        int y1;

        string maVoiture = "[]";
        string maCorrection = "  ";        
               
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
            if (x <= 1 || x >= 25 || y <= 1 || y >= 20)
            {
                x = 5;
                y = 5;
            }

            //positionement de la voiture
            /*Console.SetCursorPosition(x, y);
            Console.WriteLine(maVoiture);
            Console.SetCursorPosition(x1, y1);
            Console.WriteLine(maCorrection);*/

            // affiche x et y en bas à droite du cadre
            Console.SetCursorPosition(51, 22);
            Console.WriteLine("x=" + x + " " + "y=" + y);

            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        x1 = x;
                        y = y - 1;
                        y1 = y + 1;
                        break;
                    case ConsoleKey.DownArrow:
                        x1 = x;
                        y = y + 1;
                        y1 = y - 1;                        
                        break;
                    case ConsoleKey.LeftArrow:
                        y1 = y;
                        x = - 1;
                        x1 = x + 2;
                        break;
                    case ConsoleKey.RightArrow:
                        y1 = y;
                        x = + 1;
                        x1 = x - 2;
                        break;
                    case ConsoleKey.Escape:
                        // quite la boucle while pour retourner au menu principal
                        maBoucle = false;                        
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
                        Console.WriteLine("                ");
                        break;
                }
            }
        }

        myProgram.Initialisation();

    }

}