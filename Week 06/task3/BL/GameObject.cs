using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    class GameObject
    {
        public char[,] Shape;
        public Point startingPoint;
        public Boundary Premises;
        public string direction;

        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' } };
            startingPoint = new Point();
            Premises = new Boundary();
            direction = "LefttoRight";
        }
        public GameObject(char[,] Shape , Point StartingPoint)
        {
            this.Shape = Shape;
            this.startingPoint = StartingPoint;
            Premises = new Boundary();
            direction = "LefttoRight";
        }
        public GameObject(char[,] Shape, Point StartingPoint,Boundary Premises,string direction)
        {
            this.Shape = Shape;
            this.startingPoint = StartingPoint;
            this.Premises = Premises;
            this.direction = direction;
        }
        public void Move()
        {
            string direction2 = "Left";
            if(direction == "LefttoRight")
            {
                if (startingPoint.getY() + 1 != Premises.topRight.getY())
                {
                    startingPoint.setY(startingPoint.getY() + 1);
                }             
            }
            if (direction == "RighttoLeft")
            {
                if(startingPoint.getY() - 1 != Premises.topLeft.getY())
                {
                 startingPoint.setY(startingPoint.getY() - 1);
                }
            }


            if (direction == "Patrol")
            {
                if(direction2 == "Left")
                {
                   if(startingPoint.getY() - 1 != Premises.topLeft.getY())
                    {
                        startingPoint.setY(startingPoint.getY() - 1);
                    }
                    else
                    {
                        direction2 = "Right";
                    }
                }
                if(direction2 == "Right")
                {
                    if (startingPoint.getY() + 1 != Premises.topRight.getY())
                    {
                        startingPoint.setY(startingPoint.getY() + 1);
                    }
                }
            }
            if(direction == "Diogonal")
            {
                startingPoint.setX(startingPoint.getX() + 1);
                startingPoint.setY(startingPoint.getY() + 1);
            }
        }
        public void draw()
        {
            for(int i = 0; i < Shape.GetLength(0);i++)
            {
                for(int j = 0;j < Shape.GetLength(1);j++)
                {
                    Console.SetCursorPosition(startingPoint.getY() + j, startingPoint.getX() + i);
                    Console.Write(Shape[i,j]);

                }
            }

        }
        public void erase()
        {
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(startingPoint.getY() + j, startingPoint.getX() + i);
                    Console.Write(" ");

                }
            }

        }
    }
}
