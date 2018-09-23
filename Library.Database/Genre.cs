using System;
using System.Collections.Generic;

namespace Library.Database
{
    public partial class Genre
    {
        public Genre()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
