using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.BL
{
    class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius; 
        }
        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }
        public double getArea()
        {
            double area = 3.14 * Math.Pow(radius, 2);
            return area;
        }
        public string toString()
        {
            return "Radius : " + radius + "Color : " + color + "Area : " + getArea();

        }
    }
}
