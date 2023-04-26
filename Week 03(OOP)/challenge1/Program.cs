using challenge1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> prdct = new List<product>();
            bool exist = true;
            int option = 0;
            while(true)
            {
            option = menu(); 
                if(option == 1)
                {
                    Add(prdct);
                }
                if(option == 2)
                {
                    viewProduct(prdct);
                    Console.ReadKey();
                }
                if(option == 3)
                {
                    viewlarge(prdct);
                }
                if(option == 4)
                {
                    float tax = SalesTax();
                    Console.WriteLine("Sales Tax is : " + tax);
                    Console.ReadLine();
                }
            }
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add the product");
            Console.WriteLine("2. view the product");
            Console.WriteLine("3. Find the product with high unit price ");
            Console.WriteLine("4. view sales tax of all product ");
            Console.WriteLine("5. Products to be ordered (Less than threshHold)");
            int option;
            Console.Write("Enter the option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void Add(List<product> prdct)
        {
            Console.Clear();
            product p = new product();
            Console.Write("Enter the name of product : ");
            p.product_name = Console.ReadLine();
            Console.Write("Enter the categary of product : ");
            p.product_categary = Console.ReadLine();
            Console.Write("Enter the price of product : ");
            p.product_price = float.Parse(Console.ReadLine());
            Console.Write("Enter the stock quantity of product : ");
            p.stock_quantity = float.Parse(Console.ReadLine());
            Console.Write("Enter the minimum quantity of product : ");
            p.Minimum_quantity = float.Parse(Console.ReadLine());
            prdct.Add(p);
        }
        static void viewProduct(List<product> prdct)
        {
            Console.Clear();
            for (int i = 0;i < prdct.Count;i++)
            {
                Console.WriteLine("Name : " + prdct[i].product_name);
                Console.WriteLine("categary : " + prdct[i].product_categary);
                Console.WriteLine("price : " + prdct[i].product_price);
                Console.WriteLine("stock quantity : " + prdct[i].stock_quantity);
                Console.WriteLine("minimum quantity : " + prdct[i].Minimum_quantity);
                Console.WriteLine("-------------------------------------------");

            }
        }
        static int largest(List<product> prdct)
        {
            float largest = prdct[0].product_price;
            int index = 0;
            for(int i = 0;i < prdct.Count;i++)
            {
                if(largest < prdct[i].product_price)
                {
                    largest = prdct[i].product_price;
                    index = i;
                }
            }
            return index;
        }

        static void viewlarge(List<product> prdct)
        {
            Console.Clear();
            int ans = largest(prdct);
            Console.WriteLine("Product name : " + prdct[ans].product_name);
            Console.WriteLine("Product categary : " + prdct[ans].product_categary);
            Console.WriteLine("Product price : " + prdct[ans].product_price);
            Console.WriteLine("stock quantity : " + prdct[ans].stock_quantity);
            Console.WriteLine("Minimum stock : " + prdct[ans].Minimum_quantity);
            Console.WriteLine("------______________________------");
            Console.ReadKey();
        }
        static  float SalesTax()
        {

            product p = new product();
            float tax;
            if (p.product_categary == "Grocery")
            {
                tax = p.product_price * 0.10F;
            }
            else if (p.product_categary == "Fruit")
            {
                tax = p.product_price * 0.05F;
            }
            else
            {
                tax = p.product_price * 0.15F;
            }

            return tax;
        }
    }
}
