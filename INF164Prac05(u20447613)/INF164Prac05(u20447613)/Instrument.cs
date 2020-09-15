using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164Prac05_u20447613_
{
    public class Instrument
    {
        private string mName;
        private string mType;
        private int mVotes;

        public Instrument(string name, string type, int votes)
        {
            mName = name;
            mType = type;
            mVotes = votes;
        }

        public string Name { get => mName; set => mName = value; }
        public string Type { get => mType; set => mType = value; }
        public int Votes { get => mVotes; set => mVotes = value; }

        public int AddVotes()
        {
            return mVotes++;
        }
    }
}
