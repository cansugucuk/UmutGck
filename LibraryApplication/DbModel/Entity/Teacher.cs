using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string OtherInformations { get; set; }
        public string IBAN { get; set; }
        public int ExperienceYear { get; set; }
        public string Documents { get; set; }
        public string Photo { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string University { get; set; }
        public string WhatTeacher { get; set; }
        public string About { get; set; }
        public string YoutubeUrl { get; set; }

        [Display(Name = "Kullanıcı Tipi")]
        public int? UserTypeId { get; set; }
        public int? CountryId { get; set; }
        public int? WorkTypeId { get; set; }
        public bool IsBlocked { get; set; }
        public string ReasonBlocked { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Country Country { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual WorkType WorkType { get; set; }


        public virtual ICollection<StudentComplaint> StudentComplaint { get; set; }
        public virtual ICollection<StudentLike> StudentLike { get; set; }
        public virtual ICollection<TeacherComplaint> TeacherComplaint { get; set; }
        public virtual ICollection<TeacherLesson> TeacherLesson { get; set; }
        public virtual ICollection<TeacherLike> TeacherLike { get; set; }



    }
}