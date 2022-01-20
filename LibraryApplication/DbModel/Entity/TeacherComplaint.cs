using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class TeacherComplaint
    {
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string ComplaintReason { get; set; }
        public int StatuId { get; set; }
        public int CreatorStudentId { get; set; }
        public bool IsVisible { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Student CreatorStudent { get; set; }
        public virtual Statu Statu { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}