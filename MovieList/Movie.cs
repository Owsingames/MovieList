using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    class Movie
    {
        //properties
        public string Title {get;set;}
        public string Category { get; set; }

        //constructor
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
