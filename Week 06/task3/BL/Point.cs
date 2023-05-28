using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    class Point
    {
        public int X;
        public int Y;

       public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public int getX()
        {
            return X;
        }
        public int getY()
        {
            return Y;
        }
        public void setX(int x)
        {
            this.X = x;
           
        }
        public void setY(int y)
        {
            this.Y = y;

        }
        public void setX(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
