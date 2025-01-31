using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieService
{
    public class Movie
    {
        public string Title {  get; set; }
        public DateTime Year { get; set; }
        public string Director {  get; set; }
        public int Id { get; set; }

        public Movie() { }
        public Movie(string title, string director, DateTime year)
        {
            Id= MovieServices.Uid;
            Title = title;
            Director = director;
            Year = year;
        }
        public Movie(int id,string title, string director, DateTime year)
        {
            Id = id;
            Title = title;
            Director = director;
            Year = year;
        }
    }
}
