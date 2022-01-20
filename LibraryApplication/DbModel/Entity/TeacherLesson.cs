using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class TeacherLesson
    {
        [Key]
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int LessonId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}