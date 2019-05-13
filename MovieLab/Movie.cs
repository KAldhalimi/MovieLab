using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLab
{
    class Movie
    {
        #region DataMembers
        private string title;
        private string category;
        #endregion

        #region Properties
        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        public string Category
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }
        #endregion

        #region Constructors
        public Movie()
        {
            Title = "Movie";
        }

        public Movie(string t, string c)
        {
            Title = t;
            Category = c;
        }
        #endregion

        public void PrintInfo()
        {
            Console.WriteLine("Movie: " + Title);
        }






    }
}
    

