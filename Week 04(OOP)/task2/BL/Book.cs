using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Book
    {
        public string authorname;
        public int pages;
        public List<string> chapters = new List<string>();
        public int bookmark;
        public int price;

        public Book(string name, int pages)
        {
            this.authorname = name;
            this.pages = pages;
           
        }

        public string getChapters(int n)
        {
           
            return chapters[n-1];      
        }

        public void SetBookMark(int n)
        {
            bookmark = n;
        }
        public int getBookMark()
        {
            return bookmark;
        }
        public void SetBookprice(int price1)
        {
            price = price1;
        }
        public int getBookprice()
        {
            return price;
        }

    }
}
