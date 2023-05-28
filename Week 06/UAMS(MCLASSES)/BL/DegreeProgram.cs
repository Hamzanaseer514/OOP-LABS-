using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_MCLASSES_.BL
{
    public class DegreeProgram
    {
        public string degreeName;
        public float duration;
        public List<Subject> subjects;
        public int seats;

        public DegreeProgram(string name,float duration,int seats)
        {
            this.degreeName = name;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>(); 
        }

        public bool isSubjectExists(Subject sub)
        {
            foreach(Subject s in subjects)
            {
                if(s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if(creditHours + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public int calculateCreditHours()
        {
            int count = 0;
            for(int i = 0;i < subjects.Count;i++)
            {
                count = count + subjects[i].creditHours;
            }
            return count;
        }
    }
}
