using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Author
    {
        public Author()
        {
            this.Books = new List<Book>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string FırstName { get; set; }
        [StringLength(100)]
        public string Lastname { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}