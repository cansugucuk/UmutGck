using LibraryApplication.DbModel.Entity;
using System.Data.Entity;
using System;

namespace LibraryApplication.Concrete.Repositories
{
    internal class DataBaseContext
    {
        public class DatabaseContext : DbContext
        {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //Köprğlerimiz
                modelBuilder.Entity<Book>().HasRequired<Author>(a => a.Author).WithMany(t => t.Books).HasForeignKey(u => u.AuthorId);
                modelBuilder.Entity<Book>().HasRequired<Category>(a => a.Category).WithMany(t => t.Books).HasForeignKey(u => u.CategoryId);
                modelBuilder.Entity<Borrow>().HasRequired<Book>(a => a.Book).WithMany(t => t.Borrows).HasForeignKey(u => u.BookId);
                modelBuilder.Entity<Borrow>().HasRequired<User>(a => a.User).WithMany(t => t.Borrows).HasForeignKey(u => u.UserId);
            }
            public DatabaseContext() : base("name = LibraryContextDb")
            {
                //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, LibraryApplication.Migrations.Configuration>("LibraryContextDb"));
            }
            public virtual DbSet<Author> Authors { get; set; }
            public virtual DbSet<Book> Books { get; set; }
            public virtual DbSet<Borrow> Borrows { get; set; }
            public virtual DbSet<Category> Categories { get; set; }
            public virtual DbSet<User> Users { get; set; }
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
