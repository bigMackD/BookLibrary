using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Database;

namespace Library.Repositories
{
    public class GenresRepository
    {
        private static List<Genre> _allGenres = new List<Genre>
        {
            new Genre
            {
                Id = 1,
                Name = "Fiction"
            },
            new Genre
            {
                Id = 2,
                Name = "Adventure"
            },
            new Genre
            {
                Id = 3,
                Name = "Fantasy"
            }
        };
        public List<Genre> GetAll()
        {
            return _allGenres;
        }
        public Genre Get(int id)
        {
            return _allGenres.First(x => x.Id == id);
        }
    }
}



