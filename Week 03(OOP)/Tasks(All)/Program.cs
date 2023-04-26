using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_All_.BL;

namespace Tasks_All_
{
    class Program
    {
        static void Main(string[] args)
        {
            // task2();
            // task3();
            // task4a();
            // task4b();
            //task5();
            // task6a();
            // task6b();
            //  task7();
            // looptask();
            // clock();
            //  challenge1();
            output(86400);
            Console.ReadKey();
        }

        static void task2()
        {
            student s1 = new student();
            Console.ReadKey();
        }

        static void task3()
        {
            student s1 = new student();
            Console.WriteLine("Name : " + s1.sname);
            Console.ReadKey();
        }

        static void task4a()
        {
            student s1 = new student();
            Console.WriteLine("Name : " + s1.sname);
            Console.WriteLine("Math Marks : " + s1.matricMarks);
            Console.WriteLine("fsc marks : " + s1.fscMarks);
            Console.WriteLine("ecat marks : " + s1.ecatMarks);
            Console.WriteLine("agregate : " + s1.aggregate);
            Console.ReadKey();
        }

        static void task4b()
        {
            student s1 = new student();
            Console.WriteLine("Name : " + s1.sname);
            Console.WriteLine("Math Marks : " + s1.matricMarks);
            Console.WriteLine("fsc marks : " + s1.fscMarks);
            Console.WriteLine("ecat marks : " + s1.ecatMarks);
            Console.WriteLine("agregate : " + s1.aggregate);
            Console.WriteLine(" ");
            student s2 = new student();
            Console.WriteLine("Name : " + s2.sname);
            Console.WriteLine("Math Marks : " + s2.matricMarks);
            Console.WriteLine("fsc marks : " + s2.fscMarks);
            Console.WriteLine("ecat marks : " + s2.ecatMarks);
            Console.WriteLine("agregate : " + s2.aggregate);
            student s3 = new student();
            Console.WriteLine(" ");
            Console.WriteLine("Name : " + s3.sname);
            Console.WriteLine("Math Marks : " + s3.matricMarks);
            Console.WriteLine("fsc marks : " + s3.fscMarks);
            Console.WriteLine("ecat marks : " + s3.ecatMarks);
            Console.WriteLine("agregate : " + s3.aggregate);
            Console.ReadKey();


        }

        static void task5()
        {
            student s1 = new student("ADNAN");
            Console.WriteLine("Name : " + s1.sname);
            Console.WriteLine(" ");
            student s2 = new student("ZUBAIR");
            Console.WriteLine("Name : " + s2.sname);
            Console.ReadKey();

        }

        static void task6a()
        {
            student s1 = new student("ADNAN",1026,1012,245,89);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.ReadKey();
        }

        static void task6b()
        {
            student s1 = new student("ADNAN", 1052, 1056, 285, 89.6F);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine("");
            student s2 = new student("ZUBAIR", 1026, 1024, 245, 85.8F);
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
            Console.WriteLine("");
            student s3 = new student("HAMZA", 1012, 1026, 156, 82.5F);
            Console.WriteLine(s3.sname);
            Console.WriteLine(s3.matricMarks);
            Console.WriteLine(s3.fscMarks);
            Console.WriteLine(s3.ecatMarks);
            Console.WriteLine(s3.aggregate);
            Console.ReadKey();
        }

        static void task7()
        {
            student s1 = new student();
            s1.sname = "Hamza";
            student s2 = new student(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            Console.ReadKey();
        }

        static void looptask()
        {
            List<int> numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(" ForEach loop");

            for (int i = 0;i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("");
            Console.WriteLine(" ForEach loop");
            Console.WriteLine("");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void clock()
        {
            clockType empty = new clockType();
            Console.Write("Empty time : ");
            empty.printTime();

            clockType hours = new clockType(8);
            Console.Write("Hours time : ");
            hours.printTime();

            clockType minutes = new clockType(8,10);
            Console.Write("Minutes time : ");
            minutes.printTime();

            clockType full_time = new clockType(8,10,10);
            Console.Write("Full time : ");
            full_time.printTime();

            full_time.incrementSecond();
            Console.Write("Full time increment hours : ");
            full_time.printTime();

            full_time.incrementHours();
            Console.Write("Full time increment hours : ");
            full_time.printTime();

            full_time.incrementminutes();
            Console.Write("Full time increment minutes : ");
            full_time.printTime();



            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag : " + flag);

            clockType cmp = new clockType(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag : " + flag);
            Console.ReadKey();
        }
        static void challenge1()
        {
            int h, m, s;
            Console.Write("Enter the hours : ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Enter the minutes : ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Enter the seconds : ");
            s = int.Parse(Console.ReadLine());
            clockType clock1 = new clockType(h, m, s);
            Console.Write("Enter the hours : ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Enter the minutes : ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Enter the seconds : ");
            s = int.Parse(Console.ReadLine());
            clockType clock2 = new clockType(h, m, s);
            diff(clock1, clock2);
            clock1.elapsed(h, m, s);
            clock1.remaining(h, m, s);
            Console.ReadKey();
        }
        static void diff(clockType clock1, clockType clock2)
        {
            int total = clock1.hours * 60 * 60 + clock1.minutes * 60 + clock1.seconds;
            int total2 = clock2.hours * 60 * 60 + clock2.minutes * 60 + clock2.seconds;
            total = total - total2;
            Console.WriteLine("Difference is  : " + Math.Abs(total) + "s");
        }

        static void output(int seconds)
        {
            int h = seconds / 3600;
            seconds = seconds - h * 3600;
            int m = seconds / 60;
            seconds = seconds - m * 60;
            Console.WriteLine(h + ":" + m + ":" + seconds);


        }
    }
}
