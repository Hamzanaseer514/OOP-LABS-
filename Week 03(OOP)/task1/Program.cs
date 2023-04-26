using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.mathMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.ReadKey();
        }
    }
}
