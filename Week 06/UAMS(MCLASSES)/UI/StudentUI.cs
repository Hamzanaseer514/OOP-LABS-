using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_MCLASSES_.BL;
using UAMS_MCLASSES_.DL;

namespace UAMS_MCLASSES_.UI
{
   public class StudentUI
    {
       

        public static Student takeInputForStudent()
        {
            string name;
            int age;
            double fscMarks;
            double ecatMarks;
            List<DegreeProgram> preference = new List<DegreeProgram>();
            Console.Write("enter student name: ");
            name = Console.ReadLine();
            Console.Write("enter student age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("enter student fsc marks: ");
            fscMarks = double.Parse(Console.ReadLine());
            Console.Write("enter student ecat marks: ");
            ecatMarks = double.Parse(Console.ReadLine());
            Console.WriteLine("Available degree programs");
            DegreeProgramUI.viewDegreeProgram();
            Console.Write("Enter how many preferences to Enter : ");
            int Count = int.Parse(Console.ReadLine());
            for (int x = 0; x < Count; x++)
            {
                string degName = Console.ReadLine();
                bool flag = false;

                foreach (DegreeProgram dp in DegreeprogramDL.programList)
                {
                    if (degName == dp.degreeName && !preference.Contains(dp))
                    {
                        preference.Add(dp);
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Degree Program Name");
                    x--;
                }

            }
            Student s = new Student(name, age, fscMarks, ecatMarks,preference);
            return s;


        }
        public static void printStudents()
        {
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get Admission");
                }
            }
        }
        public static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                    }
                }
            }
        }
        public static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }

        public static void calculateFeeForAll()
        {
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "has" + s.calculateFee() + "fees ");
                }
            }
        }
    }
}
