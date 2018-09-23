using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public object GetBooksByGenreId(int id)
        {
            return _allBooks.Where(x => x.Genre.Id == id).ToList();
        }

        public List<Book> GetBooks()
        {
            return _allBooks.OrderBy(x => x.Id).ToList();
        }

        public Book GetBook(int id)
        {
            return _allBooks.FirstOrDefault(x => x.Id == id);
        }

        public int AddBook(Book book)
        {
            var maxId = _allBooks.Select(x => x.Id).Max();
            book.Id = maxId + 1;

            var genreRepository = new GenresRepository();
            book.Genre = genreRepository.Get(book.GenreId);

            _allBooks.Add(book);

            return book.Id.Value;

        }

        public void UpdateBook (Book book)
        {
            var genreRepository = new GenresRepository();
            book.Genre = genreRepository.Get(book.GenreId);
            var existingBook = _allBooks.FirstOrDefault(x => x.Id == book.Id);
            _allBooks.Remove(existingBook);
            _allBooks.Add(book);
        }

        public void RemoveBook(Book book)
        {
            var bookToBeRemoved = _allBooks.FirstOrDefault(x => x.Id == book.Id);
            _allBooks.Remove(bookToBeRemoved);
        }
    }
}
