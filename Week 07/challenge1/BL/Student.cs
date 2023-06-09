using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.BL
{
    class Student
    {
        public Student(string name, int session,bool isDayScholar,int ecatmarks,int HSMarks)
        {
            this.name = name;
            this.session = session;
            this.isDayScholar = isDayScholar;
            this.EcatMarks = ecatmarks;
            this.HSMarks = HSMarks;
        }
       protected  string name;
       protected  int session;
       protected  bool isDayScholar;
       protected  int EcatMarks;
       protected  int HSMarks;
      public float calculateMerit()
        {
            float merit = 60 * (HSMarks / 1100) + 40 * (EcatMarks / 400);
            return merit;
        }

       
    }
}
