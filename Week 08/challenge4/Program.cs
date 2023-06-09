using challenge4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Circle c = new Circle(5);
            Square s = new Square(5);
            Rectangle r = new Rectangle(5, 5);
            list.Add(c);
            list.Add(s);
            list.Add(r);
            foreach(Shape sh in list)
            {
                Console.WriteLine(sh.getArea());
                
            }
            Console.ReadKey();

        }
    }
}
