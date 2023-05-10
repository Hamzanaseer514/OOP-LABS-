using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int pages;
            Console.Write("Enter the name of author : "); 
            name = Console.ReadLine();
            Console.Write("Enter the pages of book : "); 
            pages = int.Parse(Console.ReadLine());
            Book b1 = new Book(name, pages);
            Console.WriteLine("............Chapters Data...........");
            Console.WriteLine("Enter the number of the Chapters : ");
            int n = int.Parse(Console.ReadLine());
            string chp;
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Enter the name of chapter");
                chp = Console.ReadLine();
                b1.chapters.Add(chp);
            }
            Console.WriteLine("Enter the number of Chapter you want to search");
            int chpter = int.Parse(Console.ReadLine());
            string answer = b1.getChapters(chpter);
            Console.WriteLine("Chapter is " + answer);
            Console.WriteLine(".......... Set Book mark : ");
            int mark = int.Parse(Console.ReadLine());
            b1.SetBookMark(mark);
            int getMark = b1.getBookMark();
            Console.WriteLine("Book mark is : " + getMark);
            Console.WriteLine("");
            Console.WriteLine(".......... Set Book price : ");
            int price2 = int.Parse(Console.ReadLine());
            b1.SetBookprice(price2);
            int getprice = b1.getBookprice();
            Console.WriteLine("Book price is : " + getprice);
            Console.ReadKey();

        }
    }
}
