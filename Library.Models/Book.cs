using System;
using System.ComponentModel;

namespace Library.Models
{
    public class Book
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Author")]
        public string Author { get; set; }
        [DisplayName("Year")]
        public int ProductionYear { get; set; }
        [DisplayName("Genre")]
        public Genre Genre { get; set; }

        public int GenreId { get; set; }
    }
}
