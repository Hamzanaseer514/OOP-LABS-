using Shop.BL;
using Shop.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UL
{
    class MenuItemUI
    {

        public static MenuItem AddItems()
        {
            string name;
            string type;
            float price;
            Console.Write("Enter the name of the item : ");
            name = Console.ReadLine();
            Console.Write("Enter the type of the item : ");
            type = Console.ReadLine();
            Console.Write("Enter the price of the item : ");
            price = float.Parse(Console.ReadLine());
            MenuItem m = new MenuItem(name, type, price);
            return m;
        }

        public static void printCheapestItem()
        {
            float price = CofeeShopDL.ChkCheapestItem();
            for (int i = 0; i < CofeeShopDL.itemsList.Count; i++)
            {
                if (price == CofeeShopDL.itemsList[i].price)
                {
                    Console.WriteLine("Name of item : " + CofeeShopDL.itemsList[i].name);
                    Console.WriteLine("Type of item : " + CofeeShopDL.itemsList[i].type);
                    Console.WriteLine("Price of item : " + CofeeShopDL.itemsList[i].price);
                    Console.ReadKey();
                }
            }
        }

        public static void printDrinkItem()
        {
            Console.WriteLine("Name \t\t\t\t|" + "Type \t\t\t\t|" + "Price \t\t\t\t");
            for (int i = 0; i < CofeeShopDL.itemsList.Count; i++)
            {
                if (CofeeShopDL.itemsList[i].type == "Drink" || CofeeShopDL.itemsList[i].type == "drink")
                {
                    Console.WriteLine(CofeeShopDL.itemsList[i].name + "\t\t\t\t|" + CofeeShopDL.itemsList[i].type + "\t\t\t\t|" + CofeeShopDL.itemsList[i].price);
                    
                }
            }
            Console.ReadKey();
        }

        public static void printFoodItem()
        {
            Console.WriteLine("Name \t\t\t\t|" + "Type \t\t\t\t|" + "Price \t\t\t\t");
            for (int i = 0; i < CofeeShopDL.itemsList.Count; i++)
            {
                if (CofeeShopDL.itemsList[i].type == "Food" || CofeeShopDL.itemsList[i].type == "food")
                {
                    Console.WriteLine(CofeeShopDL.itemsList[i].name + "\t\t\t\t|" + CofeeShopDL.itemsList[i].type + "\t\t\t\t|" + CofeeShopDL.itemsList[i].price);

                }
            }
            Console.ReadKey();
        }
        public static void placeOrder()
        {
            bool flag = false;
            string name;
            Console.Write("Enter the name of the item you want to buy : ");
            name = Console.ReadLine();
            for (int i = 0; i < CofeeShopDL.itemsList.Count; i++)
            {
                if(name == CofeeShopDL.itemsList[i].name)
                {
                    flag = true;
                    Console.WriteLine("Order Placed");
                    CofeeShopDL.orders.Add(name);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("Item not found");
                Console.ReadKey();
            }
        }

        public static void fullfillOrder()
        {
            Console.WriteLine(CofeeShopDL.orders[0] + " is ready ");
            CofeeShopDL.removeOrder();
            Console.ReadKey();
        }
        public static void viewOrderList()
        {
            for(int i = 0;i < CofeeShopDL.orders.Count;i++)
            {
                Console.WriteLine(CofeeShopDL.orders[i]);
            }
            Console.ReadKey();
        }
        public static void totalPayableAmount()
        {
            float price = CofeeShopDL.price();
            Console.WriteLine("Total payable price : " + price);
            Console.ReadKey();
        }

    }
}
