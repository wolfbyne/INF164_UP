using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164Prac04_u20447613_
{
    class Patron
    {
        private string mName;
        private string mSurname;
        private string mPhonenumber;
        private int mAge;

        public Patron(string name, string surname, string phonenum, int age)
        {
            mName = name;
            mSurname = surname;
            mPhonenumber = phonenum;
            mAge = age;
        }

        public string Name { get => mName; set => mName = value; }
        public string Surname { get => mSurname; set => mSurname = value; }
        public string Phonenumber { get => mPhonenumber; set => mPhonenumber = value; }
        public int Age { get => mAge; set => mAge = value; }

        public string getPatronType()
        {
            if (mAge <= 17)
            {
                return "Child Patron";
            }
            else if (mAge > 17 && mAge <= 54)
            {
                return "Adult Patron";
            }
            else if (mAge > 55)
            {
                return "Senior Patron";
            }
            else
                return "Error";
        }

    }
}
