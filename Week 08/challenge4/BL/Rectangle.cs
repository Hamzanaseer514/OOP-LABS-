using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4.BL
{
    class Rectangle:Shape
    {
        public Rectangle(int x,int y):base(x,y)
        {

        }
        public override double getArea()
        {
            return x * y;
        }
    }
}
