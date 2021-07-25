using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Book
    {
      
        [Key]
        public int Id { get; set; }

        [Display(Name = "KategoriId")]
        public int CategoryId { get; set; }

        [Display(Name = "YazarId")]
        public int AuthorId { get; set; }

        [StringLength(100)]
        [Display(Name = "Kitap Adı")]
        public string BookName { get; set; }

        [StringLength(50)]
        [Display(Name = "Raf Numarası")]
        public string ShelfNumber { get; set; }

        [Display(Name = "Sayfa Numarası")]
        public int PageNumber { get; set; }
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}
