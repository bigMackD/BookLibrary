using System;
using System.Collections.Generic;

namespace Library.Database
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ProductionYear { get; set; }
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
