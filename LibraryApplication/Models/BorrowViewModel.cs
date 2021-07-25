using LibraryApplication.DbModel.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class BorrowViewModel
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Kullanıcı Id")]
        public int UserId { get; set; }

        [Display(Name = "Kitap Id")]
        public int BookId { get; set; }

        [Display(Name = "Ödünç Alma Tarihi")]
        public DateTime StartingDate { get; set; }

        [Display(Name = "Ödünç Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }


    }
}
