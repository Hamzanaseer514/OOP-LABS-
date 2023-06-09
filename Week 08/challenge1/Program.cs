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
            double radius = 4.0;
            double height = 3.0;
            string color = "Red";
            Cylinder c = new Cylinder();
            Cylinder c1 = new Cylinder(radius, height);
            Cylinder c2 = new Cylinder(radius, height, color);
            c2.setHeight(3.0);
            double volume =  c2.getVolume();
            Console.WriteLine("Volume is : " + volume);
            Console.ReadKey();
        }
    }
}
