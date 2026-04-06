using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06   
{
    internal interface IMovieService
    {
        Movie GetById(int id);
        Movie GetByName(string name);
        void Add(Movie Movie);
    }
}
