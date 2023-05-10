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
            List<Student> student = new List<Student>();
            string name;
            int rollno;
            float cgpa;
            int fscMark;
            int ecatMark;
            string home;
            bool isHostalite;
            bool isEligible;

            Console.Write("Enter the name of student : ");
            name = Console.ReadLine();
            Console.Write("Enter the rollNo of student : ");
            rollno = int.Parse(Console.ReadLine());
            Console.Write("Enter the cgpa of student : ");
            cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter the fscMarks of student : ");
            fscMark = int.Parse(Console.ReadLine());
            Console.Write("Enter the ecatMarks of student : ");
            ecatMark = int.Parse(Console.ReadLine());
            Console.Write("Enter the home town : ");
            home = Console.ReadLine();
            Console.Write("Enter student is hostalite (true or false) : ");
            isHostalite = bool.Parse(Console.ReadLine());
            Console.Write("Enter student is eligible for scholarship (true or false) : ");
            isEligible = bool.Parse(Console.ReadLine());
            Student s1 = new Student(name, rollno, cgpa, fscMark, ecatMark, home, isHostalite, isEligible);
            student.Add(s1);
            float merit = s1.calculateAggregate();
            Console.WriteLine("Your aggregate is : " + merit);
            Console.ReadKey();
            bool result = isEligiblescholar(merit, student);

            if (result == false)
            {
                Console.WriteLine("Student not found");
                Console.ReadKey();
            }




        }
        static bool isEligiblescholar(float merit, List<Student> student)
        {
            string name;
            bool flag2 = false;
            Console.Write("Enter the name of the Student : ");
            name = Console.ReadLine();
            if (name == student[0].name)
                {
                    flag2 = true;
                    if (merit > 80 && student[0].isHostalite == true)
                    {
                        Console.WriteLine("Student is Eligible for the Scholarship ");
                        Console.ReadKey();
                     
                    }
                    else
                    {
                        Console.WriteLine("Student is not Eligible for the Scholarship");
                        Console.ReadKey();
                    }
                }
                else
                {
                    flag2 = false;
                }
            
          
            return flag2;
        }
    }
}
