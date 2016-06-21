using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private string FormDuCadre1 = "vide";
    private string FormDuCadre2 = "vide";

    static void Main(string[] args)
    {
        Program myProgram = new Program();  // instance de programme permmetant de faire appel tout les tout les void publique

        myProgram.Initialisation();

         bool maBoucle = true;
         while (maBoucle) // boucle permetant de lire les touches
         {

             if (Console.KeyAvailable)
             {
                 switch (Console.ReadKey().Key)
                 {
                     case ConsoleKey.F5:
                         myProgram.Initialisation();
                         break;
                     case ConsoleKey.F6:
                         Console.Clear();
                         Console.ForegroundColor = ConsoleColor.White;
                         Console.WriteLine("couscous");
                         Thread.Sleep(2000);

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
        int y = 3;

        Console.SetCursorPosition(x, y);
        Console.WriteLine("Helloworld");
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
        
}