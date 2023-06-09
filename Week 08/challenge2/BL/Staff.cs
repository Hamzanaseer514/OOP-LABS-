using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class Staff:Person
    {
        private string school;
        private double pay;
        public Staff(string name,string adress,string school,double pay):base(name,adress)
        {
            this.school = school;
            this.pay = pay;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public string getSchool()
        {
            return school;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public double getpay()
        {
            return pay;
        }
        public override string toString()
        {
            return "Name : " + getName() + "     Adress : " + getAdress() + "   School : " + school + "   Pay : " + pay;
        }
    }
}
