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
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; } //konu
        public string Message { get; set; }

    }
}
