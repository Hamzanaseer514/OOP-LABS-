using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_MCLASSES_.BL;
using UAMS_MCLASSES_.DL;
using UAMS_MCLASSES_.UI;

namespace UAMS_MCLASSES_
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string subjectPath = "subject.txt";
            string degreePath = "degree.txt";
            string studentPath = "student.txt";
            List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
            List<Student> studentList = new List<Student>();
            if (SubjectDL.readffromfile(subjectPath))
            {
                Console.WriteLine("SUbject DATA LOADED");
            }
            if (DegreeprogramDL.readffromfile(degreePath))
            {
                Console.WriteLine("SUbject DATA LOADED");
            }
            if (StudentDL.readFromFile(studentPath))
            {
                Console.WriteLine("SUbject DATA LOADED");
            }

            int option;
            do
            {
                option = MenuUI.Menu();
                MenuUI.clearScreen();
                if (option == 1)
                {
                    if (DegreeprogramDL.programList.Count > 0)
                    {
                        Student s = StudentUI.takeInputForStudent();
                        StudentDL.addIntoStudentList(s);
                        StudentDL.storeintoFile(studentPath, s);

                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = DegreeProgramUI.takeInputForDegree();
                    DegreeprogramDL.addIntoDegreeList(d);
                    DegreeprogramDL.storeintofile(degreePath, d);
                }
                else if (option == 3)
                {
                    List<Student> sortedStudentList = new List<Student>();
                    sortedStudentList = StudentDL.sortStudentByMerit();
                    StudentDL.giveAdmission(sortedStudentList);
                    StudentUI.printStudents();
                }
                else if (option == 4)
                {
                    StudentUI.viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("Enter Degree Name : ");
                    degName = Console.ReadLine();
                    StudentUI.viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the Student Name : ");
                    string name = Console.ReadLine();
                    Student s = StudentDL.Studentpresent(name);
                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    StudentUI.calculateFeeForAll();
                }
                MenuUI.clearScreen();

            } while (option != 8);
            Console.ReadKey();
        }
    }
}
