using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164_A2_U20447613
{
    class Pet
    {
        private string mName;
        private string mType;
        private int mAge;
        private int mIDnum;

        public Pet(string name, int age, string type, int id)
        {
            mName = name;
            mType = type;
            mAge = age;
            mIDnum = id;
        }

        public string Name { get => mName; set => mName = value; }
        public string Type { get => mType; set => mType = value; }
        public int Age { get => mAge; set => mAge = value; }
        public int IDnum { get => mIDnum; set => mIDnum = value; }
    }
}
