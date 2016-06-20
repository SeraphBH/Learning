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
        static void Main(string[] args)
        {
            PersonalisationAleatoir();
            CadreMenu();
            MenuInteraction();
            Console.ReadLine();
         }
        static void CadreMenu()
        {
            Console.WriteLine("*******************************************************");
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("*                                                     *");
            }
            Console.WriteLine("*******************************************************");
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
            for (int i = 1; i <= 50; i++)
            {
                int maValeur = new Random().Next(1, 5);
                Console.WriteLine(maValeur);
                Thread.Sleep(20);
                
            }
        }
    }
}
