using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4.BL
{
    class Square:Shape
    {
        public Square(int x) : base(x)
        {

        }
        public override double getArea()
        {
            return x * x;
        }
    }
}
