using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.BL
{
     class Hostalite : Student
    {
        public Hostalite(string roomNumber, bool isInternetavailable,bool isFridgeAvailable,string name,int session,bool isDayScholar,int ecatMarks,int HSMarks) : base(name,session,isDayScholar,ecatMarks,HSMarks)
        {
            this.roomNumber = roomNumber;
            this.isInternetAvailalble = isInternetavailable;
            this.isFridgeAvailable = isFridgeAvailable;
        }
        string roomNumber;
        bool isInternetAvailalble;
        bool isFridgeAvailable;
        public float hostalFee()
        {
            float roomfee = 5000;
            if(isInternetAvailalble == true)
            {
                roomfee += 1200;
            }
            if(isFridgeAvailable == true)
            {
                roomfee += 1000;
            }
            return roomfee;
        }
    }
}
