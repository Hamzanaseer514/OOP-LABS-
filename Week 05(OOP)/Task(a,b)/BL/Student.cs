using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_a_b_.BL
{
    class Student
    {
        public string name;
        public int rollNo;
        public int ecatMarks;

        public Student(string name,int rollno,int ecatMarks)
        {
            this.name = name;
            this.rollNo = rollno;
            this.ecatMarks = ecatMarks;
        }
        public Student()
        {
        }
    }
}

