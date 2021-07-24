using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Category
    {
       
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}