using LibraryApplication.DbModel.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class AuthorViewModel
    {
      
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Display(Name = "Soyad")]
        public string Lastname { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}