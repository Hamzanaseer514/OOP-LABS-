using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_a_b_.BL;

namespace Task_a_b_
{
    class Program
    {
        static void Main(string[] args)
        {

              task1();
              Console.WriteLine("");
              task2();
              Console.WriteLine("");
              task3();
            
        }
        static void task1()
        {
            List<string> random = new List<string>() { "Hamza", "Awais", "Zubair", "Hasnaat", "Musa Butt" };
            random.Sort();
            for (int i = 0; i < random.Count; i++)
            {
                Console.Write(random[i] + " ");
            }
            Console.ReadKey();
        }
        static void task2()
        {
            List<float> sort = new List<float>() {23F,45.5F,23F,12F,45F,3F,1F,0.99F};
            sort.Sort();
            for (int i = 0; i < sort.Count; i++)
            {
                Console.Write(sort[i] + " ");
            }
            Console.ReadKey();
        }

        static void task3()
        {
            Student s1 = new Student("Hassan", 17, 156);
            Student s2 = new Student("Awais", 14, 250);
            Student s3 = new Student("Hamza", 15, 185);
            List<Student> studentList = new List<Student>() { s1, s2, s3 };
            List<Student> sortedList = studentList.OrderBy(o => o.rollNo).ToList();
            Console.WriteLine("Name \t Rollno \t EcatMarks");
            foreach (Student s in sortedList)
            {
                Console.WriteLine(s.name + "\t" + s.rollNo + "\t" + s.ecatMarks);
            }
            Console.ReadKey();
        }
    }
}
