using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge3.BL
{
    class Cat:Mammal
    {
        public Cat(string name):base(name)
        {

        }
        public override void greet()
        {
            Console.WriteLine("Meow");
        }
        public override string toString()
        {
            return "Name : " + name;
        }
    }
}
