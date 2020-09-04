using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164Prac04_u20447613_
{
    class Book
    {
        private string mTitle;
        private string mAuthor;
        private string mPublishDate;
        private string mGenre;
        private double mRating;

        public Book(string title, string author, string date, string genre, double rating)
        {
            mTitle = title;
            mAuthor = author;
            mPublishDate = date;
            mGenre = genre;
            mRating = rating;
        }

        public string Title { get => mTitle; set => mTitle = value; }
        public string Author { get => mAuthor; set => mAuthor = value; }
        public string PublishDate { get => mPublishDate; set => mPublishDate = value; }
        public string Genre { get => mGenre; set => mGenre = value; }
        public double Rating { get => mRating; set => mRating = value; }

        public bool eBookAvailable()
        {
            string pubdate = mPublishDate;
            DateTime date = Convert.ToDateTime(pubdate);
            int year = date.Year;
            if (year<2016)
            {
                return false;
            } else
                return true;
        }
    }
}
