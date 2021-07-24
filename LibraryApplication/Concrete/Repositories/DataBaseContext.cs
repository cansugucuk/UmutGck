using LibraryApplication.DbModel.Entity;
using System.Data.Entity;
using System;

namespace LibraryApplication.Concrete.Repositories
{
    //public class DataBaseContext
    //{
        public class DataBaseContext : DbContext
        {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //Köprğlerimiz
                modelBuilder.Entity<Book>().HasRequired<Author>(a => a.Author).WithMany(t => t.Books).HasForeignKey(u => u.AuthorId);
                modelBuilder.Entity<Book>().HasRequired<Category>(a => a.Category).WithMany(t => t.Books).HasForeignKey(u => u.CategoryId);
                modelBuilder.Entity<Borrow>().HasRequired<Book>(a => a.Book).WithMany(t => t.Borrows).HasForeignKey(u => u.BookId);
                modelBuilder.Entity<Borrow>().HasRequired<User>(a => a.User).WithMany(t => t.Borrows).HasForeignKey(u => u.UserId);
            }
            public DataBaseContext() : base("name = LibraryContextDb")
            {
                //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, LibraryApplication.Migrations.Configuration>("LibraryContextDb"));
            }
            public  DbSet<Author> Authors { get; set; }
            public  DbSet<Book> Books { get; set; }
            public  DbSet<Borrow> Borrows { get; set; }
            public  DbSet<Category> Categories { get; set; }
            public  DbSet<User> Users { get; set; }
        }

        //internal DbSet<T> Set<T>()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}
    //}
}
