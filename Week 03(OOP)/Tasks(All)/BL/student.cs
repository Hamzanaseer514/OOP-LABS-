using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_All_.BL
{
    class student
    {
         public student()
         {
             Console.WriteLine("Default constructor called");
            // sname = "Jill";
            // matricMarks = 1000F;
            // fscMarks = 1026F;
            // ecatMarks = 220F;
            // aggregate = 89.8F;
        
         }
        public student(string sname)
        {
            this.sname = sname;
        }
        public student(string sname,float matricMarks,float fscMarks,float ecatMarks,float aggregate)
        {
            this.sname = sname;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.aggregate = aggregate;
        }

        public student(student s)
        {
            sname = s.sname;
            matricMarks = s.matricMarks;
            fscMarks = s.fscMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
