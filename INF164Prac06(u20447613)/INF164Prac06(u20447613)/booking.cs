using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164Prac06_u20447613_
{
    [Serializable]
    public class Booking
    {

        private string mName;
        private string mSurname;
        private int mPhoneNumber;
        private DateTime mDate;
        private string mSession;
        private string mType;

        public Booking()
        {

        }

        public Booking(string name, string sur, int pnum, DateTime date, string sess, string typ)
        {
            mName = name;
            mSurname = sur;
            mPhoneNumber = pnum;
            mDate = date;
            mSession = sess;
            mType = typ;
        }

        public void cardMachine()
        {
            if (mType.Equals("Card"))
            {
                string msg = "Remember to bring along a card machine with you!";
            }
        }

        public string Name { get => mName; set => mName = value; }
        public string Surname { get => mSurname; set => mSurname = value; }
        public int PhoneNumber { get => mPhoneNumber; set => mPhoneNumber = value; }
        public DateTime Date { get => mDate; set => mDate = value; }
        public string Session { get => mSession; set => mSession = value; }
        public string Type { get => mType; set => mType = value; }
    }
}
