using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangl = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] optriangleb = new char[5, 3] { { ' ', '@', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObject g1 = new GameObject(triangl, new Point(5, 5), b,"LefttoRight");
            GameObject g2 = new GameObject(optriangleb, new Point(30, 60),b, "RighttoLeft");
            List<GameObject> lst = new List<GameObject>();
            lst.Add(g1);
            lst.Add(g2);
            while(true)
            {
                Thread.Sleep(2000);
                foreach(GameObject g in lst)
                {
                    g.erase();
                    g.Move();
                    g.draw();

                }
            }
        }
    }
}
