using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4.BL
{
    class Circle : Shape
    {
        public Circle(int x) : base(x)
        {

        }
        public override double getArea()
        {
            return (2 * Math.PI * x * x);
        }
    }
}
