using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Subject
    {
        public string subjectCode;
        public float creditHours;
        public string subjectType;
        public double fees;
        public Subject(string code,int hours,string name,double fees)
        {
            this.subjectCode = code;
            this.creditHours = hours;
            this.subjectType = name;
            this.fees = fees;
        }
    }
}
