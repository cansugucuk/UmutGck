using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class StudentLike
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string LikeReason { get; set; }
        public int StatuId { get; set; }
        public int CreatorTeacherId { get; set; }
        public bool? IsVisible { get; set; }

        public virtual Teacher CreatorTeacher { get; set; }
        public virtual Statu Statu { get; set; }
        public virtual Student Student { get; set; }

    }
}