using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5.BL;

namespace task5
{
    class Program
    {
      

        static void Main(string[] args)
        {
            char option;
            Students[] s = new Students[10];
            int count = 0;
            while(true)
            {


                option = menu();
                if (option == '1')
                {
                   s[count] =  AddStudent();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewStudent(s, count);
                }
                else if (option == '3')
                {
                    TopStudent(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
            }
        }

        static char menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. View the Students");
            Console.WriteLine("3. For top three Students");
            Console.WriteLine("4. Exit");
            char option;
            Console.Write("Enter the option : ");
            option = char.Parse(Console.ReadLine());
            return option;

        }

        static Students AddStudent()
        {
            Console.Clear();
            Students s1 = new Students();
            Console.Write("Enter the name of the student : ");
            s1.name = Console.ReadLine();

            Console.Write("Enter the roll no of the student : ");
            s1.roll_no = int.Parse(Console.ReadLine());

            Console.Write("Enter the CGPA of the student : ");
            s1.cgpa = float.Parse(Console.ReadLine());

            Console.Write("Is student hostalite or not (n/y) : ");
            s1.isHostalide = char.Parse(Console.ReadLine());

            Console.Write("Enter the department of the student : ");
            s1.department = (Console.ReadLine());

            return s1;
        }

        static void TopStudent(Students[] s, int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Record found  ");
            }
            else if (count == 1)
            {
                viewStudent(s, 1);
            }
            else if (count == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    int index = largest(s, i, count);
                    Students temp = s[index];
                    s[index] = temp;
                    s[i] = temp;
                }
                viewStudent(s, 2);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(s, i, count);
                    Students temp = s[index];
                    s[index] = temp;
                    s[i] = temp;

                }
                viewStudent(s, 3);
            }
        }

        static int largest(Students[] s, int start, int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for(int i = start;i < end;i++)
            {
                if(large < s[i].cgpa)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;
        }

        static void viewStudent(Students[] s, int count)
        {
            Console.Clear();
            for(int i = 0; i < count;i++)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Name : " + s[i].name);
                Console.WriteLine("");
                Console.Write("Roll no : " + s[i].roll_no);
                Console.WriteLine("");
                Console.Write("CGPA : " + s[i].cgpa);
                Console.WriteLine("");
                Console.Write("Hostalite : " + s[i].isHostalide);
                Console.WriteLine("");
                Console.Write("Department : " + s[i].department);
                Console.WriteLine("");
            }
            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey();

        }
    }
}

