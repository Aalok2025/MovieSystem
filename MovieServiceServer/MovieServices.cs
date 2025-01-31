using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieService
{
    public class MovieServices : IMovieService
    {
        private Dictionary<string, Movie> movieList=new Dictionary<string, Movie> ();
        private Movie currentMovie;
        public static int Uid = 1;
        private string filePath = "movies.json";
        //File
        public string InitialLoadMovieFromFile()
        {
            string filePath = "movies.json";
            StringBuilder sb=new StringBuilder();

            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                return "\nMovies file was empty or missing. No changes made.";
            }

            try
            {
                string jsonData = File.ReadAllText(filePath).Trim();

                if (string.IsNullOrWhiteSpace(jsonData) || jsonData == "[]")
                {
                    return "\nMovies file was empty. No changes made.";
                }

                var tempMovieList = JsonSerializer.Deserialize<Dictionary<string, Movie>>(jsonData) ?? new Dictionary<string, Movie>();
                sb.Append("This is File MovieList. Click on Load to add this in local/temporary List.");
                foreach (var kvp in tempMovieList)
                {
                    sb.Append($"\nID: {kvp.Value.Id}\nTitle: {kvp.Key}\nYear of Release: {kvp.Value.Year}\nDirector: {kvp.Value.Director}\n");
                }
                Console.WriteLine("Movies loaded successfully (Data NOT merged yet).");
                return sb.ToString();
            }
            catch (JsonException jsonEx)
            {
                return $"\nInvalid JSON format: {jsonEx.Message}";
            }
            catch (Exception ex)
            {
                return $"\nError loading movies: {ex.Message}";
            }
        }
        public bool SaveMovieListToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(movieList, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(filePath, json);
                Console.WriteLine("Movie list saved successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving movie list: " + ex.Message);
                return false;
            }
        }
        public void ClearMovieFromFile()
        {
            string filePath = "movies.json";
            try
            {
                if (File.Exists(filePath))
                {
                    File.WriteAllText(filePath, "");
                }
                Console.WriteLine("Movie list cleared successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error clearing movie list: " + ex.Message);
            }
        }
        public string LoadMovieFromFile()
        {
            StringBuilder sb = new StringBuilder();

            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                return "\nMovies file was empty or missing. No changes made.";
            }

            try
            {
                string jsonData = File.ReadAllText(filePath).Trim();

                if (string.IsNullOrWhiteSpace(jsonData) || jsonData == "[]")
                {
                    return "\nMovies file was empty. No changes made.";
                }

                var tempMovieList = JsonSerializer.Deserialize<Dictionary<string, Movie>>(jsonData) ?? new Dictionary<string, Movie>();

                foreach (var kvp in tempMovieList)
                {
                    sb.Append($"\nID: {kvp.Value.Id}\nTitle: {kvp.Key}\nYear of Release: {kvp.Value.Year}\nDirector: {kvp.Value.Director}\n");
                }
                if (tempMovieList.Count > 0)
                {
                    foreach (var kvp in tempMovieList)
                    {
                        movieList[kvp.Key] = kvp.Value;
                    }
                }
                Console.WriteLine("Movies loaded successfully (Data NOT merged yet).");
                return sb.ToString();
            }
            catch (JsonException jsonEx)
            {
                return $"\nInvalid JSON format: {jsonEx.Message}";
            }
            catch (Exception ex)
            {
                return $"\nError loading movies: {ex.Message}";
            }
        }
        //Navigation
        public Movie First()
        {
            if (movieList.Count() != 0)
            {
                string firstKey = movieList.Keys.First();
                Movie firstValue = movieList[firstKey];
                currentMovie = firstValue;
                return firstValue;
            }
            else
            {
                return null;
            }

        }
        public Movie Last()
        {
            if (movieList.Count() != 0)
            {
                string lastKey = movieList.Keys.Last();
                Movie lastMovie = movieList[lastKey];
                currentMovie = lastMovie;
                return lastMovie;
            }
            else
            {
                return null;
            }
        }
        public Movie Next()
        {
            List<Movie> MovieList = movieList.Values.ToList();
            int index=MovieList.FindIndex(m=>m==currentMovie);
            if(index>=MovieList.Count()-1)
            {
                Console.WriteLine("You have Reached End of List!");
                return null;
            }
            else
            {
                currentMovie = MovieList[index+1];
                return MovieList[index+1];
            }
            
        }
        public Movie Previous()
        {
            List<Movie> MovieList = movieList.Values.ToList();
            int index = MovieList.FindIndex(m => m == currentMovie);
            if (index < 1)
            {
                Console.WriteLine("You have Reached End of List!");
                return null;
            }
            else
            {
                currentMovie = MovieList[index - 1];
                return MovieList[index - 1];
            }
        }
        //List
        public void AddMovieToList(int id, string title, string director, DateTime year)
        {
            Movie m = new Movie(title, director, year) { Id = id };
            movieList[title] = m;
        }
        public string LoadLocal()
        {
            StringBuilder sb = new StringBuilder();
            if (movieList.Count != 0)
            {
                foreach (KeyValuePair<string, Movie> kvp in movieList)
                {
                    sb.Append($"\nID : {kvp.Value.Id}\nTitle : {kvp.Key}\nYear of Release : {kvp.Value.Year}\nDirector : {kvp.Value.Director}");
                }
                Console.WriteLine("\nMovies loaded successfully.");
                return sb.ToString();
            }
            else
            {
                return ("\nMovies file not found! \nFile Empty!");
            }
        }
        public string UpdateMovieToList(int id, string title, string director, DateTime year)
        {
            if (movieList.ContainsKey(title))
            {
                if (movieList[title].Id == id)
                {
                    movieList[title] = new Movie(title, director, year) { Id = id };
                    return $"Movie '{title}' updated successfully.";
                }
                else
                {
                    return $"Error: Movie '{title}' exists but the provided {movieList[title].Id}!={id} does not match.";
                }
            }
            else
            {
                return $"Error: Movie '{title}' not found in the list.";
            }
        }
        public bool DeleteFromList(Movie m)
        {
            if(movieList.ContainsKey(m.Title))
            {
                  movieList.Remove(m.Title);
                  return true;
            }
                return false;
        }
        public void ClearMovieFromList()
        {
            movieList.Clear();
        }
    }
}
