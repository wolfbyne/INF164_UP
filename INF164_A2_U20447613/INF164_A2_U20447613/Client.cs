using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164_A2_U20447613
{
    class Client
    {
        private string mName;
        private string mSurname;
        private int mIDnum;
        private int mCredLimit;
        private int mCurrentBalOwed;

        public Client(int id, string name, string surname, int credlim, int currentBalOwed)
        {
            mName = name;
            mSurname = surname;
            mIDnum = id;
            mCredLimit = credlim;
            mCurrentBalOwed = currentBalOwed;
        }

        public string Name { get => mName; set => mName = value; }
        public string Surname { get => mSurname; set => mSurname = value; }
        public int IDnum { get => mIDnum; set => mIDnum = value; }
        public int CredLimit { get => mCredLimit; set => mCredLimit = value; }
        public int CurrentBalOwed { get => mCurrentBalOwed; set => mCurrentBalOwed = value; }

        public int calcCurrentBal(int payment, int purchase)
        {
            int currentbal =  purchase - payment;
            return currentbal;
        }
    }
}
