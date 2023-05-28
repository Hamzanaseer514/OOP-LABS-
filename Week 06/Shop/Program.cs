using Shop.BL;
using Shop.DL;
using Shop.UL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            int option = 0;
            while(option != 9)
            {
                option = MenuUI.Menu();
                MenuUI.clearScreen();
                if(option == 1)
                {
                    MenuItem m = MenuItemUI.AddItems();
                    CofeeShopDL.AddItemIntoList(m);
                }
                if(option == 2)
                {
                    MenuItemUI.printCheapestItem();
                }
                if(option == 3)
                {
                    MenuItemUI.printDrinkItem();
                }
                if(option == 4)
                {
                    MenuItemUI.printFoodItem();
                }
                if(option == 5)
                {
                    MenuItemUI.placeOrder();
                }
                if(option == 6)
                {
                    MenuItemUI.fullfillOrder();
                }
                if(option == 7)
                {
                    MenuItemUI.viewOrderList();
                } 
                if(option == 8)
                {
                    MenuItemUI.totalPayableAmount();
                }
                if(option > 9 || option < 1)
                {
                    Console.WriteLine("Invalid ");
                    Console.ReadKey();
                }
            }
        }
    }
}
