using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Entity
{
    public class StudentLesson
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Price { get; set; }

        public virtual Lesson Lesson { get; set; }

    }
}