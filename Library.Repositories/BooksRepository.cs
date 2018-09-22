using Library.Models;
using System;
using System.Collections.Generic;

namespace Library.Repositories
{
    public class BooksRepository
    {
        private static List<Book> _allBooks = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Naked Lunch",
                Author = "W.Burroughs",
                ProductionYear = 1959,
                Genre = new Genre
                {
                    Id = 1,
                    Name = "Novel"
                }
            },
             new Book
            {
                Id = 2,
                Title = "Domowe warzenie piwa",
                Author = "L.Richard",
                ProductionYear = 2007,
                Genre = new Genre
                {
                    Id = 1,
                    Name = "Tutorial"
                }
            }
        };
        public List<Book> GetBooks()
        {
            return _allBooks;
        }
    }
}
