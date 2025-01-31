using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieService
{
    public interface IMovieService
    {
        //File
        string InitialLoadMovieFromFile();
        bool SaveMovieListToFile();
        string LoadMovieFromFile();
        //List
        string LoadLocal();
        string UpdateMovieToList(int id, string title, string director, DateTime year);
        void AddMovieToList(int id, string title, string director, DateTime year);
        void ClearMovieFromFile();
        void ClearMovieFromList();
        bool DeleteFromList(Movie m);
        //Navigation
        Movie Next();
        Movie Previous();
        Movie First();
        Movie Last();

    }
}
