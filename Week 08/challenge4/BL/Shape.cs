using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge4.BL
{
    class Shape
    {
        protected int x;
        protected int y;
        public Shape(int x)
        {
            this.x = x;
            this.y = 0;
        }
        public Shape(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double getArea()
        {
            return 0;
        }
    }
}
