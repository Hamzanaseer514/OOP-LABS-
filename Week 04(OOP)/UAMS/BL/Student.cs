using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Student
    {
        public string name;
        public int age;
        public float fscMarks;
        public float ecatMarks;
        public float merit;
        public List<Degree> preferences = new List<Degree>();
        public Degree regDegree;
        public double sum = 0;

        public Student(string name,int age,float fscMarks,float ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            regDegree = new Degree();   
        }
        public float calculateMerit()
        {
            float result = (40 * ecatMarks) / 400 + (60 * fscMarks) / 1100;
            return result;
        }
        public void calculateFees(double fees)
        {
            sum = sum + fees;
           
        }

    }
}
