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
            char option;
            Products[] s = new Products[10];
            int count = 0;
            while (true)
            {


                option = menu();
                if (option == '1')
                {
                    s[count] = AddStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewProducts(s, count);
                }
                else if (option == '3')
                {
                    totalWorth(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
            }
        }

        static char menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Show the product");
            Console.WriteLine("3. Total Worth");
            Console.WriteLine("4. Exit");
            char option;
            Console.Write("Enter the option : ");
            option = char.Parse(Console.ReadLine());
            return option;

        }

        static Products AddStudent()
        {
            Console.Clear();
            Products s1 = new Products();
            Console.Write("Enter the Id of the product : ");
            s1.id = Console.ReadLine(); 
            
            Console.Write("Enter the name of the product : ");
            s1.name = Console.ReadLine();

            Console.Write("Enter the categary of the product : ");
            s1.catogary = Console.ReadLine();

            Console.Write("Enter the brand of the product : ");
            s1.brand = Console.ReadLine();

            Console.Write("Enter the country  : ");
            s1.country = Console.ReadLine();


            Console.Write("Enter the price of the product : ");
            s1.price = float.Parse(Console.ReadLine());

            return s1;
        }

  

 
        static void viewProducts(Products[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("ID : " + s[i].id);
                Console.WriteLine("");
                Console.Write("Name : " + s[i].name);
                Console.WriteLine("");
                Console.Write("Categary : " + s[i].catogary);
                Console.WriteLine("");
                Console.Write("Country : " + s[i].country);
                Console.WriteLine("");
                Console.Write("Brand : " + s[i].brand);
                Console.WriteLine("");
                Console.Write("Price : " + s[i].price);
                Console.WriteLine("");
            }
            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();

        }

        static void totalWorth(Products[] s,int count)
        {
            float sum = 0F;
            for(int i = 0; i < count;i++)
            {
                sum = sum + s[i].price;
            }
            Console.Write("your total amount is : " + sum);
            Console.ReadKey();
        }
    }
    }

