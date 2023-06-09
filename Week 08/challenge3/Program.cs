using challenge3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Cat c1 = new Cat("Persian");
            Cat c2 = new Cat("Tom");
            Dog d1 = new Dog("puppy");
            Dog d2 = new Dog("chotu");
            list.Add(c1);
            list.Add(c2);
            list.Add(d2);
            list.Add(d1);
            foreach(Animal m in list)
            {
                Console.WriteLine(m.toString());
                Console.ReadKey();
            }
        }
    }
}
