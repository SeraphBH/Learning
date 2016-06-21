using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        string FormDuCadre1 = "vide";
        string FormDuCadre2 = "vide";
        static void Main(string[] args)
        {

            PersonalisationAleatoir();
            CadreMenu();
            MenuInteraction();
            Console.ReadLine();
         }
        static void CadreMenu()
        {
            Console.WriteLine(FormDuCadre1);
            for (int i = 1; i <= 15; i++) 
            {
                Console.WriteLine(FormDuCadre2);
            }
            Console.WriteLine(FormDuCadre1);
        }
        static void MenuInteraction()
        {
            int x = 3; 
            int y = 3;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Helloworld");
            

        }
        static void PersonalisationAleatoir()


        {
            int maValeur = 0; 
            for (int i = 1; i <= 5; i++)
            {
                maValeur = new Random().Next(1, 6);                               
            }
            switch (maValeur)
                {
                    case 1:                    
                        FormDuCadre1 = "*******************************************************";
                        FormDuCadre2 = "*                                                     *";
                        break;
                    case 2:
                   
                        FormDuCadre1 = "-------------------------------------------------------";
                        FormDuCadre2 = "-                                                     -";
                        break;
                    case 3:
                    
                        FormDuCadre1 = "#######################################################";
                        FormDuCadre2 = "#                                                     #";
                        break;
                    case 4:
                    
                        FormDuCadre1 = "=======================================================";
                        FormDuCadre2 = "|                                                     |";
                        break;
                      case 5:
                    
                        FormDuCadre1 = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
                        FormDuCadre2 = "~                                                     ~";
                        break;
                }                                                                

            }

        }
    }

