using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_Task
{
    class Program
    {
       // private static object file;

        static void Main(string[] args)
        {
            string path = "D:\\2nd semester OOP\\OOP labs\\Week 01\\pizza Task\\pizza File.txt";
            string line;
            int order;
            int orderPrice;
            int size = 0;
            Console.Write("Enter the number of orders : ");
            order = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the minimum price : ");
            orderPrice = int.Parse(Console.ReadLine());
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    size++;
                }
                file.Close();
            }

            int i = 0;
            string[] name = new string[size];
            string[] orderList = new string[size];
            int[] orderNumber = new int[size];
            if(File.Exists(path))
            {
                    StreamReader file = new StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    name[i] = parseString(line, 1);
                    orderNumber[i] = int.Parse(parseString(line, 2));
                    orderList[i] = parseString(line, 3);
                }
                file.Close();
            }
            for (int j = 0;j < size;j++)
            {
                orderList[j] = orderList[j].Substring(1, orderList[j].Length - 1);
                orderList[j] = orderList[j].Substring(0, orderList[j].Length - 1);
                orderList[j] = orderList[j].Trim();
            }
            for(int j = 0; j < size;j++)
            {
                int counter = 0;
                for(int l = 0;l < orderList[j].Length;l++)
                {
                    if(Parse(orderList[j], l+1, orderList[j].Length) >= orderPrice)
                        {
                              counter++;
                         }
                }
                if(counter >= order)
                {
                    Console.WriteLine(name[j]);
                }
            }
            Console.ReadKey();
        }

        static string parseString(string line, int field)
        {
            int count = 1;
            string item = "";
            for(int i = 0; i < line.Length;i++)
            {
                if(count == field)
                {
                    item = item + line[i];
                }
                if(line[i] == ' ')
                {
                    count++;
                }
            }
            return item;
        }

         static int Parse(string line, int field, int length)
        {
            int CommaCount = 1;
            string item = "";
            {
                for(int i = 0; i < line.Length;i++)
                {
                    if (line[i] == ',')
                    {
                        CommaCount++;
                      
                    }
                    else if(CommaCount == field)
                    {
                        item = item + line[i];

                    }
                }
            }
            if(item != "")
            {
                int result = int.Parse(item);
                return result;
            }
            else
            {
                return 0;
            }
        }
    }
}

        
    

