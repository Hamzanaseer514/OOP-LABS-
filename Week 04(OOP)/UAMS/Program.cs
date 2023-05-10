using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            List<Student> sortedstudent = new List<Student>();
            List<Degree> degree = new List<Degree>();
            int option = 0;
            while (option != 9)
            {
                Console.Clear();
                print();
                option = menu();
                if (option == 1)
                {
                    if (degree.Count > 0)
                    {
                        while (true)
                        {
                            AddStudent(student, degree);
                            Console.WriteLine("Do you want to continue Y/N : ");
                            char choice = char.Parse(Console.ReadLine());
                            if (choice == 'y' || choice == 'Y')
                            {
                                continue;
                            }
                            else if (choice == 'n' || choice == 'N')
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Enter the valid input ");
                                Console.ReadKey();
                                continue;
                            }
                        }
                    }

                }
                else if (option == 2)
                {
                    degreeProgram(degree);
                }
                else if (option == 3)
                {
                    sortedStudentByMerit(student, sortedstudent);
                    giveAdmission(sortedstudent, degree, student);
                    printStudent(sortedstudent);
                }
                else if (option == 4)
                {
                    registerStudent(sortedstudent);
                }
                else if (option == 5)
                {
                    viewStudent(sortedstudent);
                }
                else if (option == 6)
                {
                    addSubject(sortedstudent, degree);
                }
                else if(option == 7)
                {
                    fees(sortedstudent);
                }
                else if (option > 8 || option < 1)
                {
                    Console.WriteLine("Invalid Response");
                    Console.ReadKey();
                }
            }
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Register Student");
            Console.WriteLine("5. View Students at a specific program");
            Console.WriteLine("6. Register Subjects for a specific Student");
            Console.WriteLine("7. Calculate fees for all Registered Students");
            Console.WriteLine("8. Exit");
            int option;
            Console.Write("Enter the option : ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static void print()
        {
            Console.WriteLine("............................................................................................");
            Console.WriteLine("");
            Console.WriteLine("                                           U A M S                                                ");
            Console.WriteLine("");
            Console.WriteLine("............................................................................................");
        }

        static void AddStudent(List<Student> student, List<Degree> degree)
        {
            string name;
            int age;
            float fscMarks;
            float ecatMarks;
            Console.Write("Enter the name of the student : ");
            name = Console.ReadLine();
            Console.Write("Enter the age of the student : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter the fsc marks of the student : ");
            fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter the ecat marks of the student : ");
            ecatMarks = float.Parse(Console.ReadLine());
            Student s1 = new Student(name, age, fscMarks, ecatMarks);

            Console.Write("Enter the number of preferences you want to add : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter the degree : ");
                string name2 = Console.ReadLine();
                bool result = AddPreferences(degree, name2);
                if (result == true)
                {
                    s1.preferences.Add(degree[i]);
                }
                else
                {
                    Console.Write("Degree is not available");
                    Console.ReadKey();
                }
            }
            student.Add(s1);
        }

        static void degreeProgram(List<Degree> degree)
        {
            string name;
            int duration;
            int seats;
            string code;
            int hours;
            string type;
            double fees;
            Console.Write("Enter the name of degree : ");
            name = Console.ReadLine();
            Console.Write("Enter the duration of degree : ");
            duration = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of seats : ");
            seats = int.Parse(Console.ReadLine());
            Degree d1 = new Degree(name, duration, seats);
            Console.Write("Enter the number of Subjects : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Clear();
                Console.Write("Enter the code of the subject : ");
                code = Console.ReadLine();
                Console.Write("Enter the number of hours : ");
                hours = int.Parse(Console.ReadLine());
                Console.Write("Enter the type of subject : ");
                type = Console.ReadLine();
                Console.Write("Enter the fees of sunject : ");
                fees = double.Parse(Console.ReadLine());
                Subject s1 = new Subject(code, hours, type, fees);
                d1.subject.Add(s1);
            }
            degree.Add(d1);
        }

        static bool AddPreferences(List<Degree> degree, string name2)
        {
            bool flag = false;
            for (int x = 0; x < degree.Count; x++)
            {
                if (name2 == degree[x].degreeTitle)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        static void sortedStudentByMerit(List<Student> student, List<Student> sortedstudent)
        {
            for (int i = 0; i < student.Count; i++)
            {
                student[i].merit = student[i].calculateMerit();
            }
            sortedstudent.AddRange(student);
            float largest = 0F;
            int index = 0;
            largest = student[index].merit;
            for (int i = 1; i < sortedstudent.Count; i++)
            {
                if (largest < sortedstudent[i].merit)
                {
                    largest = sortedstudent[i].merit;
                    Student s2 = student[index];
                    sortedstudent.Remove(student[index]);
                    sortedstudent.Insert(index, student[i]);
                    sortedstudent.Remove(student[i]);
                    sortedstudent.Insert(i, s2);
                    index = i;
                }
                else
                {
                    continue;
                }
            }

        }
        static void giveAdmission(List<Student> sortedstudent, List<Degree> degree, List<Student> student)
        {
            for (int i = 0; i < sortedstudent.Count; i++)
            {
                for (int j = 0; j < sortedstudent[i].preferences.Count; j++)
                {
                    for (int k = 0; k < degree.Count; k++)
                    {
                        if (sortedstudent[i].preferences[j].degreeTitle == degree[k].degreeTitle && degree[k].seats > 0)
                        {
                            sortedstudent[i].regDegree.degreeTitle = degree[k].degreeTitle;
                        }
                    }
                }
            }
        }
        static void printStudent(List<Student> sortedstudent)
        {
            for (int i = 0; i < sortedstudent.Count; i++)
            {
                if (sortedstudent[i].regDegree.degreeTitle != "")
                {
                    Console.WriteLine("{0} Got Admission in {1} ", sortedstudent[i].name, sortedstudent[i].regDegree.degreeTitle);

                }
                else
                {
                    Console.WriteLine("{0} didnot get admission ", sortedstudent[i].name);
                }
            }
        }

        static void registerStudent(List<Student> sortedstudent)
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            for (int i = 0; i < sortedstudent.Count; i++)
            {
                if (sortedstudent[i].regDegree.degreeTitle != "")
                {
                    Console.WriteLine(sortedstudent[i].name + "\t" + sortedstudent[i].fscMarks + "\t" + sortedstudent[i].ecatMarks + "\t" + sortedstudent[i].age);
                }
            }
        }
        static void viewStudent(List<Student> sortedstudent)
        {
            Console.Write("Enter the program name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            for (int i = 0; i < sortedstudent.Count; i++)
            {
                if (sortedstudent[i].regDegree.degreeTitle == name)
                {
                    Console.WriteLine(sortedstudent[i].name + "\t" + sortedstudent[i].fscMarks + "\t" + sortedstudent[i].ecatMarks + "\t" + sortedstudent[i].age);
                }
            }
        }

        static void addSubject(List<Student> sortedstudent, List<Degree> degree)
        {
            Console.Write("Enter the student name : ");
            string name = Console.ReadLine();
            for (int i = 0; i < sortedstudent.Count; i++)
            {
                if (name == sortedstudent[i].name)
                {
                    Console.WriteLine("Enter the subject code : " );
                    string code = Console.ReadLine();
                    for(int j = 0;j < degree.Count;j++)
                    {

                    if(degree[j].degreeTitle == sortedstudent[i].regDegree.degreeTitle)
                        {
                            for(int k = 0;k < degree[j].subject.Count;k++)
                            {
                                if(degree[j].subject[k].subjectCode == code)
                                {
                                    sortedstudent[i].calculateFees(degree[j].subject[k].fees);
                                    Console.WriteLine("You are registered Successfully");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("This student is not registered");
                }
            }
        }
        static void fees(List<Student> sortedstudent)
        {
            for(int i =0;i < sortedstudent.Count;i++)
            {
                if(sortedstudent[i].regDegree.degreeTitle != "")
                {
                    Console.WriteLine("{0} fees is {1} ",sortedstudent[i].name,sortedstudent[i].sum);
                }
            }
        }
    }
}
