using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06
{
    internal class MovieService : IMovieService
    {
        static Movie[] movies = [];

        public Movie GetByName(string name)
        {

            foreach (var item in movies)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            Console.WriteLine("Name tapilmadi");
            return null;
        }

        public Movie GetById(int id)
        {
            foreach (var item in movies)
            {
                if (item.Id == id)
                {
                    return item;
                } 
            }
            Console.WriteLine("Id tapilmadi");
            return null;
        }

        public void Add(Movie movie)
        {
            foreach (var item in movies)
            {
              if(item.Name==movie.Name)
                {
                    throw new Exception();
                }
            }
            Array.Resize(ref movies, movies.Length + 1);
            movies[movies.Length - 1] = movie;
        }
    }
}
