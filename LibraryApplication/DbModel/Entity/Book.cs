using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Book
    {
        public Book()
        {
            this.Borrows = new List<Borrow>();
        }
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        [StringLength(100)]
        public string BookName { get; set; }

        [StringLength(50)]

        public string ShelfNumber { get; set; }
        public int PageNumber { get; set; }

        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}
