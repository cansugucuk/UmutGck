using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }


    }
}
