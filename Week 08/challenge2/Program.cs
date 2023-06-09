using challenge2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Student s1 = new Student("hamza", "sambrial", "computer Science", 1, 56000);
            Student s2 = new Student("Awais", "sheikhupura", "computer Science", 1, 56000);
            Staff st1 = new Staff("saad", "lahore", "UET", 100000);
            Staff st2 = new Staff("abdulrehman", "malkhanwala", "PUCIT", 100000);
            list.Add(s1);
            list.Add(s2);
            list.Add(st1);
            list.Add(st2);
            foreach(Person p in list)
            {
                Console.WriteLine(p.toString());
                Console.ReadKey();
            }
        }
    }
}
