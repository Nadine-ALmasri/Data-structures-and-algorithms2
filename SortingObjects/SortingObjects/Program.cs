using System.Collections;
using System.Collections.Generic;

namespace SortingObjects
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Movie> Movies = new List<Movie>
    {
        new Movie { Title = "The Mindset", Year = 2005, Genres = new List<string> { "Sci-Fi", "Action" } },
        new Movie { Title = "Mother", Year = 2023, Genres = new List<string> { "Action", "Drama" } },
        new Movie { Title = "A Beautiful Mind", Year = 2001, Genres = new List<string> {  "Drama" } },
          new Movie { Title = "Spider Man", Year = 2009, Genres = new List<string> {  "Drama" } },
    };
            // Sort movies by most recent year
            Movies.Sort((a, b) => SortingMovies.CompareByYear(a, b));
            // Print sorted movies
            Console.WriteLine("________________________________________________________________________________________");
            Console.WriteLine("Sorting depending on Year ");
            Console.WriteLine("________________________________________________________________________________________");
            foreach (var movie in Movies)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year})");
            }
            Console.WriteLine("________________________________________________________________________________________");
            // Sort movies alphabetically by title
            Console.WriteLine("Sorting alphabetically by title ");
            Console.WriteLine("________________________________________________________________________________________");
            Movies.Sort((a, b) => SortingMovies.CompareByTitle(a, b));
            // Print sorted movies
            foreach (var movie in Movies)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year})");
            }
        }
    }
}