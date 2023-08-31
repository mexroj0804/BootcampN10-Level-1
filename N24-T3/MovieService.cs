using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_T3
{
    public class MovieService
    {
        List<Movie> movies = new()
        {
            new Movie("Eternal Echoes", "Samantha Carter", 8),
            new Movie("Whispers in the Wind", "Benjamin Turner", 7),
            new Movie("Midnight Serenade", "Emily Mitchell", 9),
            new Movie("Forgotten Realms", "Alexander Roberts", 6),
            new Movie("Starlit Secrets", "Olivia Parker", 8),
            new Movie("Shadows of Yesterday", "Michael Hughes", 7),
            new Movie("Dreams of Tomorrow", "Sophia Walker", 9),
            new Movie("Eternal Echoes", "Daniel Adams", 8),
            new Movie("Whispers of Hope", "Lily Johnson", 7),
            new Movie("Rays of Eternity", "Christopher Baker", 6)
        };

        public void Search(string searchKeywoard)
        {
            movies.Where(movie => movie.Name.Contains(searchKeywoard, StringComparison.OrdinalIgnoreCase) && movie.Author.Contains(searchKeywoard, StringComparison.OrdinalIgnoreCase))
                .ToList().ForEach(item => Console.WriteLine(item.Name + "\t" + item.Author + "\t" + item.Rating));

        }

        public void Add(string name, string author, int rating)
        {
            var foundMovie = movies
                .FirstOrDefault(movie => movie.Name.Contains(name, StringComparison.OrdinalIgnoreCase) && movie.Author.Contains(author, StringComparison.OrdinalIgnoreCase));

            if (foundMovie != null)
            {
                movies.Add(new Movie { Name = name, Author = author, Rating = rating });
            }
        }
    }
}
