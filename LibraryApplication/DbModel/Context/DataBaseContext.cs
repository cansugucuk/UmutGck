using LibraryApplication.DbModel.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryApplication.DbModel.Context
{
    public class DataBaseContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Köprğlerimiz
            modelBuilder.Entity<Book>().HasRequired<Author>(a => a.Author).WithMany(t => t.Books).HasForeignKey(u => u.AuthorId);
            modelBuilder.Entity<Book>().HasRequired<Category>(a => a.Category).WithMany(t => t.Books).HasForeignKey(u => u.CategoryId);
            modelBuilder.Entity<Borrow>().HasRequired<Book>(a => a.Book).WithMany(t => t.Borrows).HasForeignKey(u => u.BookId);
            modelBuilder.Entity<Borrow>().HasRequired<User>(a => a.User).WithMany(t => t.Borrows).HasForeignKey(u => u.UserId);


            modelBuilder.Entity<Comment>().HasRequired<Student>(a => a.Student).WithMany(t => t.Comment).HasForeignKey(u => u.StudentId);

        }
        public DataBaseContext() : base("name = LibraryContextDb")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, LibraryApplication.Migrations.Configuration>("LibraryContextDb"));
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Statu> Status { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<WorkType> WorkTypes { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentComplaint> StudentComplaints { get; set; }
        public virtual DbSet<StudentLesson> StudentLessons { get; set; }
        public virtual DbSet<StudentLike> StudentLikes { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherComplaint> TeacherComplaints { get; set; }
        public virtual DbSet<TeacherLesson> TeacherLessons { get; set; }
        public virtual DbSet<TeacherLike> TeacherLikes { get; set; }
        public virtual DbSet<Country> Countrys { get; set; }
    }
}