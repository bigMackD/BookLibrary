using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Library.Database
{
    public class Genre
    {
        public int Id { get; set; }

        [DisplayName("Genre")]
        public string Name { get; set; }

    }
}
