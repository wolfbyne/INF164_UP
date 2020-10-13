using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u20447613ClassTest2
{
    [Serializable]
    public class Book
    {
        private string mName;
        private string mAuthor;
        private string mQuality;
        private string mType;
        private int mYear;
        private double mPrice;

        public Book()
        {

        }

        public Book(string name, string type, string auth, string quality,  int year, double price)
        {
            mName = name;
            mType = type;
            mAuthor = auth;
            mQuality = quality;
            mYear = year;
            mPrice = price;
        }

        public string Name { get => mName; set => mName = value; }
        public string Type { get => mType; set => mType = value; }
        public string Author { get => mAuthor; set => mAuthor = value; }
        public string Quality { get => mQuality; set => mQuality = value; }
        public int YearOfPublication { get => mYear; set => mYear = value; }
        public double Price { get => mPrice; set => mPrice = value; }

        public double PriceValue()
        {
            if (mType.ToLower().Equals("fiction"))
            {
                if (mYear < 2000 && mQuality.ToLower().Equals("used"))
                {
                    return (110 - 20) * 0.9;
                }
                else if (mYear < 2000)
                {
                    return (110 - 20);
                }
                else if (mQuality.ToLower().Equals("used"))
                {
                    return 110 * 0.9;
                }
                else
                    return 110;
            }
            else if (mType.ToLower().Equals("non-fiction"))
            {
                if (mYear < 2000 && mQuality.ToLower().Equals("used"))
                {
                    return (90 - 20) * 0.9;
                }
                else if (mYear < 2000)
                {
                    return (90 - 20);
                }
                else if (mQuality.ToLower().Equals("used"))
                {
                    return 90 * 0.9;
                }
                else
                    return 110;
            }
            else
                return 0;
        }
    }
}
