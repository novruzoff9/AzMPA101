using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06
{
    internal class Movie
    {
        static int IdCount = 0;
        public int Id { get; set; }
        public double AverageRating { get; set; }
        public int RatingsCount { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public Genre Genre { get; set; }
        public Movie()
        {
            Id=++IdCount;
        }
        public void Rate(double rate)
        {   if (rate > 10){
                throw new Exception("Qiymetlendirme 0 ve 10 arasinda olmalidir.");
            }
            double total = AverageRating * RatingsCount;
            total += rate;
            RatingsCount += 1;
            AverageRating = total / RatingsCount;
        }
    }   
}
