using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.BL
{
    class DayScholar
    {
        public DayScholar(bool isCardAvailable,string pickupLocation,int busNo,int pickupDistance, string name, int session, bool isDayScholar, int ecatMarks, int HSMarks) : base(name, session, isDayScholar, ecatMarks, HSMarks)
        {
            this.isBusCardAvailable = isCardAvailable;
            this.pickupLocation = pickupLocation;
            this.busNo = busNo;
            this.pickUpDistance = pickupDistance;
        }
        bool isBusCardAvailable;
        string pickupLocation;
        int busNo;
        int pickUpDistance;

        public float claculateFee()
        {
            float fee = 1000;
            if(pickUpDistance > 15)
            {
                fee += 500;
            }
            if(pickUpDistance < 10)
            {
                fee -= 1000;
            }
            return fee;
        }
    }
}
