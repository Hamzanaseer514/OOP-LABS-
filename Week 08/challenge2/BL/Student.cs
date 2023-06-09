using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fees;
        public Student(string name,string adress,string program,int year,double fee):base(name,adress)
        {
            this.program = program;
            this.year = year;
            this.fees = fee;
        }

        public void setProgram(string program)
        {
            this.program = program;
        }
        public string getProgram()
        {
            return program;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }
        public void setFee(double fee)
        {
            this.fees = fee;
        }
        public double getFee()
        {
            return fees;
        }
        public override string toString()
        {
            return "Name : " + getName() + "     Adress : " + getAdress() + "   program : " + program + "   Year : " + year + "    Fee : " + fees;
        }
    }
}
