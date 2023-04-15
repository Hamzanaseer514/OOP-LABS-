using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tasks
{
    class Program
    {
        class Students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            task3();
        }

        static void task1()
        {
            Students s1 = new Students();
            s1.name = "Ameer Hamza";
            s1.roll_no = 17;
            s1.cgpa = 3.65F;
            Console.WriteLine("Name : " + s1.name);
            Console.WriteLine("Roll no  : " + s1.roll_no);
            Console.WriteLine("CGPA : " + s1.cgpa);
            Console.WriteLine("");
            Console.Read();
        }

        static void task2()
        {
            Students s1 = new Students();
            s1.name = "Ameer Hamza";
            s1.roll_no = 17;
            s1.cgpa = 3.65F;
            Console.WriteLine("Name : " + s1.name);
            Console.WriteLine("Roll no  : " + s1.roll_no);
            Console.WriteLine("CGPA : " + s1.cgpa);
            Console.WriteLine("");
            Students s2 = new Students();
            s2.name = "Muhammad Awais";
            s2.roll_no = 30;
            s2.cgpa = 3.6F;
            Console.WriteLine("Name : " + s2.name);
            Console.WriteLine("Roll no  : " + s2.roll_no);
            Console.WriteLine("CGPA : " + s2.cgpa);
            Console.Read();
        }

        static void task3()
        {
            Students s1 = new Students();
            Console.WriteLine("Enter the name of the students : ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter the roll no of the students : ");
            s1.roll_no =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the CGPA of the students : ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Name :  {0}  Rollno :  {1}  CGPA :  {2}", s1.name, s1.roll_no, s1.cgpa);
            Console.Read();

        }

        static void task4()
        {

        }
    }
}
