using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class Student
    {
        public string name;
        public int rollNo;
        public float cgpa;
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostalite;
        public bool IsEligibleForScholarship;
        public Student(string name, int rollno, float cgpa, int fscMark, int ecatMark, string home, bool isHostalite, bool isEligible)
        {
            this.name = name;
            this.rollNo = rollno;
            this.cgpa = cgpa;
            this.fscMarks = fscMark;
            this.ecatMarks = ecatMark;
            this.homeTown = home;
            this.isHostalite = isHostalite;
            this.IsEligibleForScholarship = isEligible;
        }
        public float calculateAggregate()
        {
            float result;
            result = (40 * ecatMarks) / 400 + (60 * fscMarks) / 1100;
            return result;
        }
    }
}
