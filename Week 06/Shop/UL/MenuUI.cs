using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UL
{
    class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("...................................");
            Console.WriteLine("...........Coffee Shop.............");
            Console.WriteLine("...................................");
        }

        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Menu Item");
            Console.WriteLine("2. View the cheapest in the Menu");
            Console.WriteLine("3. View the Drinks Menu");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4. View the Foods Menu");
            Console.WriteLine("5. Add order");
            Console.WriteLine("6. FullFill the order ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("7. view the Order List");
            Console.WriteLine("8. Total Payable amount");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("9. Exit");
            Console.ForegroundColor = ConsoleColor.White;
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
    }
}
