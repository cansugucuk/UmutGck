using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class User
    {
        public User()
        {
            this.Borrows = new List<Borrow>();
        }
        [Key]
        public int Id { get; set; }
        public int Type { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string FırstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Telephone { get; set; }
        [StringLength(100)]
        public string UserAddres { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public string Password { get; set; }
     
        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}