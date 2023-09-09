using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingObjects
{
   public  class SortingMovies
    {

        public static int CompareByYear(Movie a, Movie b)
        {

            return b.Year - a.Year;
        }
        public static int CompareByTitle(Movie a, Movie b)
        {

            string NormalizeTitle(string title)
            {
                title = title.Trim();
                if (title.StartsWith("A ", StringComparison.OrdinalIgnoreCase) ||
                    title.StartsWith("An ", StringComparison.OrdinalIgnoreCase) ||
                    title.StartsWith("The ", StringComparison.OrdinalIgnoreCase))
                {
                    // Remove the prefix and convert the rest of the title to lowercase
                    title = title.Substring(title.IndexOf(' ') + 1).ToLower();
                }
                else
                {
                    // Convert the entire title to lowercase
                    title = title.ToLower();
                }
                return title;
            }
            return string.Compare(NormalizeTitle(a.Title), NormalizeTitle(b.Title), StringComparison.Ordinal);

        }
    }
}
