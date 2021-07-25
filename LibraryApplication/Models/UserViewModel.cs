using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.Models
{
    public class UserViewModel
    {
       
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tip")]
        public int? Type { get; set; }

        [StringLength(100)]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [StringLength(100)]
        [Display(Name = "Adı")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }

        [StringLength(100)]
        [Display(Name = "Telefon")]
        public string Telephone { get; set; }

        [StringLength(100)]
        [Display(Name = "Kullanıcı Adres")]
        public string UserAddres { get; set; }

        [StringLength(100)]
        [Display(Name = "E Posta")]
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }
     
        //public virtual ICollection<Borrow> Borrows { get; set; }
    }
}