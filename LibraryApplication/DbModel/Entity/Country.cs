using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Country
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Şehir")]
        public string Name { get; set; }

    }
}