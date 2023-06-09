using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2.BL
{
    class Person
    {
        private string name;
        private string adress;
        public Person(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }
        public void setAdress(string adress)
        {
            this.adress = adress;
        }
        public string getAdress()
        {
            return adress;
        }
        public string getName()
        {
            return name;
        }
        public virtual string toString()
        {
            return "Name : " + name + "Adress : " + adress;
        }  

    }
}
