using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "You have to pass book title!")]
        [MaxLength(50,ErrorMessage ="Title can not be longer than 50 chars!")]
        public string Title { get; set; }

        [MaxLength(50, ErrorMessage = "Author's name can not be longer than 50 chars!")]
        [DisplayName("Author")]
        public string Author { get; set; }

        [DisplayName("Year")]
        public int ProductionYear { get; set; }

        [MaxLength(50, ErrorMessage = "Genre can not be longer than 50 chars!")]
        [DisplayName("Genre")]
        public Genre Genre { get; set; }

        public int GenreId { get; set; }
    }
}
