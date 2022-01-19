using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class UserType
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Kullanıcı Tipi")]
        public string Name { get; set; }

    }
}