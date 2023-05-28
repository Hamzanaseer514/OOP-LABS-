using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_MCLASSES_.BL
{
    public class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> preference;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;

        public Student(string name, int age,double fscMarks,double ecatMarks,List<DegreeProgram> preference)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preference = preference;
            regSubject = new List<Subject>();
           
        }
        public void calculateMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;
            
        }
        public bool regStudentSubject(Subject s)
        {
            int ch = getCreditHours();
            if(regDegree != null && regDegree.isSubjectExists(s) && ch + s.creditHours <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getCreditHours()
        {
            int count = 0;
            foreach(Subject sub in regSubject)
            {
                count = count + sub.creditHours;
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if(regDegree != null)
            {
                foreach(Subject sub in regSubject)
                {
                    fee = fee + sub.subjectFees;
                }
            }
            return fee;
        }


    }
}
