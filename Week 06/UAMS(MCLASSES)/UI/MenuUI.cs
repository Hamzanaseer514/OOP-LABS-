using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_MCLASSES_.UI
{
    public class MenuUI
    {
        public static void header()
        {
            Console.WriteLine("...................................");
            Console.WriteLine("............  UAMS ................");
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
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Register Subjects");
            Console.WriteLine("4. Calculate Merit");
            Console.WriteLine("5. Calculate Fees");
            Console.WriteLine("6. View Registered Students");
            Console.WriteLine("7. View Students of Specific Program");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("9. Exit");
            Console.ForegroundColor = ConsoleColor.White;
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
    }
}
