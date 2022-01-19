using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Lesson
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Ders Adı")]
        public string Name { get; set; }

    }
}