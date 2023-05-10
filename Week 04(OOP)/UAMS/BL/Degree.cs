using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Degree
    {
        public string degreeTitle;
        public int degreeDuration;
        public int seats;

        public List<Subject> subject = new List<Subject>();
        public Degree()
        {
            degreeTitle = "";
            degreeDuration = 0;
            seats = 0;
        }
        public Degree(string name,int duration,int seats)
        {
            this.degreeTitle = name;
            this.degreeDuration = duration;
            this.seats = seats;
        }
       
    }
}
