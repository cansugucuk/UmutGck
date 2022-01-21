using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Display(Name = "Telefon No")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Sıınıf")]
        public int GradeNumber { get; set; }
        //public string Documents { get; set; }
        //public string Photo { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }
        //public DateTime Birthdate { get; set; }

        [Display(Name = "Şehir")]
        public int? CountryId { get; set; }
        //public bool IsBlocked { get; set; }
        //public string ReasonBlocked { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public bool IsActive { get; set; }

        [Display(Name = "Kullanıcı Tipi")]
        public int UserTypeId { get; set; }

        [Display(Name = "Şehir")]
        public virtual Country Country { get; set; }
        public virtual UserType UserType { get; set; }


        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<StudentComplaint> StudentComplaint { get; set; }
        public virtual ICollection<StudentLike> StudentLike { get; set; }
        public virtual ICollection<TeacherComplaint> TeacherComplaint { get; set; }
        public virtual ICollection<TeacherLike> TeacherLike { get; set; }



    }
}