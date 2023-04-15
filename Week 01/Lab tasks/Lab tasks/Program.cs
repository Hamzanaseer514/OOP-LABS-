using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task18();
        }

        static void task1()
        {
            Console.WriteLine("Hello World");
            Console.Write("Hello World");
            Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
        static void task3()
        {
            int number = 23;
            Console.Write("Number : ");
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static void task4()
        {
            float value = 23.6F;
            Console.Write("Value : ");
            Console.WriteLine(value);
            Console.ReadKey();
        }
        static void task5()
        {
            string number = "Adnan";
            Console.Write("String: " + number);
            Console.ReadKey();
        }
        static void task6()
        {
            char number = 'A';
            Console.Write("Character: " + number);
            Console.ReadKey();
        }

       
      
        static void task7()
        {
            int number;
            Console.WriteLine("Enter Integer");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number : ");
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static void task8()
        {
            string word;
            Console.WriteLine("Enter String");
            word = Console.ReadLine();
            Console.WriteLine("String : " );
            Console.WriteLine(word);
            Console.ReadKey();
        }
        static void task9()
        {
            char name;
            Console.WriteLine("Enter Character");
            name = char.Parse(Console.ReadLine());
            Console.WriteLine("Character: " + name);
            Console.ReadKey();
        }
        static void task10()
        {
            float number;
            Console.WriteLine("Enter Number");
            number = float.Parse(Console.ReadLine());
            Console.WriteLine("Character: " + number);
            Console.ReadKey();
        }
        static void task11()
        {
            float marks;
            Console.WriteLine("Enter Your Marks");
            marks = float.Parse(Console.ReadLine());
            if (marks > 50)
            {
                Console.Write("You are passed");
                Console.ReadKey();
            }
            if (marks <= 50)
            {
                Console.Write("You are Failed");
                Console.ReadKey();

            }


        }
        static void task12()
        {
            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("Welcome to UET");
            }
          //  Console.ReadKey();
        }
        static void task13()
        {
            int number;
            int sum = 0;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            while(number != -1)
            {
                sum = sum + number;
                Console.Write("Enter the number : ");
                number = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The total sum is : ");
            Console.Write(sum);
            Console.Read();
        }

        static void task14()
        {
            int number;
            int sum = 0;
            do
            {
                Console.Write("Enter the number : ");
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            while (number != -1);
            sum = sum + 1;
            Console.Write("The total sum is  : ");
            Console.Write(sum);
           Console.Read();
           
        }

        static void task15()
        {
            int[] variable = new int[3];
            for(int i = 0;i < 3; i++)
            {
                Console.Write("Enter the number : ", i);
                variable[i] = int.Parse(Console.ReadLine());
            }

            int largest = -1;
            for (int i = 0; i < 3; i++)
            {
                if (variable[i] > largest)
                {
                    largest = variable[i];
                }
            }
            Console.WriteLine("The largest value is : ");
            Console.Write(largest);
            Console.Read();
        }

       static void task16()
        {
            int number1;
            int number2;
            Console.Write("Enter the first number : ");
            number1 = int .Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            number2 = int .Parse(Console.ReadLine());
            int result = add(number1, number2);
            Console.WriteLine("Sum is {0} : ", result);
            Console.Read();

        }

        static int add(int number1,int number2)
        {
            return  number1 + number2;
        }

        static void task17()
        {
            string path = "D:\\2nd semester OOP\\OOP labs\\Week 01\\Lab tasks\\text File.txt";
            if(File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);  
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("NOT EXISTS");
            }
           
        }

        static void task18()
        {
            string path = "D:\\2nd semester OOP\\OOP labs\\Week 01\\Lab tasks\\text File.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);
            fileVariable.WriteLine("Hello Hamza");
            fileVariable.Flush();
            fileVariable.Close();
        }




    }
}
    

