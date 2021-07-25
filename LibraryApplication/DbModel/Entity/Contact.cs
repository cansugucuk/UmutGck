using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Contact
    {
      
        [Key]
        public int ContactId { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Kullanıcı E-Posta")]
        public string UserMail { get; set; }

        [Display(Name = "Konu")]
        public string Subject { get; set; } //konu

        [Display(Name = "Mesaj")]
        public string Message { get; set; }


    }
}
