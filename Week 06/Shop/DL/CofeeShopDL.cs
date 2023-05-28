using Shop.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DL
{
    class CofeeShopDL
    {
        public static List<MenuItem> itemsList = new List<MenuItem>();
        public static List<string> orders = new List<string>();

        public static void AddItemIntoList(MenuItem m)
        {
            itemsList.Add(m);
        }

        public static float ChkCheapestItem()
        {
            float minprice = itemsList[0].price;
            for(int i = 1;i < itemsList.Count;i++)
            {
                if(minprice < itemsList[i].price)
                {
                    continue;
                }
                else
                {
                    minprice = itemsList[i].price;
                }
            }
            return minprice;
        }
        public static void removeOrder()
        {
            orders.RemoveAt(0);
        }
        public static float price()
        {
            float price = 0;
            for(int i = 0;i < orders.Count;i++)
            {
                for(int j = 0;j < itemsList.Count;i++)
                {
                    if(orders[i] == itemsList[j].name)
                    {
                        price += itemsList[j].price; 
                    }
                }
            }
                return price;
        }

    }
}
