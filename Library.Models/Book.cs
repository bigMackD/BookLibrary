using System;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int ProductionYear { get; set; }
        public Genre Genre { get; set; }
    }
}
