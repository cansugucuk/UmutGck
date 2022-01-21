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
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Diğer Bilgiler")]
        public string OtherInformations { get; set; }
        public string IBAN { get; set; }

        [Display(Name = "Deneyim Yılı")]
        public int ExperienceYear { get; set; }
        //public string Documents { get; set; }
        //public string Photo { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }
        //public DateTime Birthdate { get; set; }

        [Display(Name = "Mezun Olunan Üniversite Adı")]
        public string University { get; set; }

        [Display(Name = "Öğretmenlik Branşı")]
        public string WhatTeacher { get; set; }

        [Display(Name = "Hakkında")]
        public string About { get; set; }

        [Display(Name = "Youtube URL")]
        public string YoutubeUrl { get; set; }

        [Display(Name = "Kullanıcı Tipi")]
        public int? UserTypeId { get; set; }

        [Display(Name = "Şehir")]
        public int? CountryId { get; set; }

        [Display(Name = "Çalışma Tipi")]
        public int? WorkTypeId { get; set; }
        //public bool IsBlocked { get; set; }
        //public string ReasonBlocked { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public bool IsActive { get; set; }

        [Display(Name = "Şehir")]
        public virtual Country Country { get; set; }
        public virtual UserType UserType { get; set; }

        [Display(Name = "Çalışma Tipi")]
        public virtual WorkType WorkType { get; set; }


        public virtual ICollection<StudentComplaint> StudentComplaint { get; set; }
        public virtual ICollection<StudentLike> StudentLike { get; set; }
        public virtual ICollection<TeacherComplaint> TeacherComplaint { get; set; }
        public virtual ICollection<TeacherLesson> TeacherLesson { get; set; }
        public virtual ICollection<TeacherLike> TeacherLike { get; set; }



    }
}