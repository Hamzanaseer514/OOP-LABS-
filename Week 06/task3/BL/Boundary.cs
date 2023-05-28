using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    class Boundary
    {
        public Point topLeft;
        public Point topRight;
        public Point bottomLeft;
        public Point bottomRight;

        public Boundary()
        {
            topLeft = new Point(0, 0);
            topRight = new Point(0, 90);
            bottomLeft = new Point(90, 0);
            bottomRight = new Point(90, 90);
        }
        public Boundary(Point topleft, Point topright,Point bottomleft,Point bottomright)
        {
            this.topLeft = topleft;
            this.topRight = topright;
            this.bottomLeft = bottomleft;
            this.bottomRight = bottomright;
        }
    }
}
