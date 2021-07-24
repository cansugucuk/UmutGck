using LibraryApplication.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryApplication.DbModel.Entity;
using System.Data.Entity;
using System.Linq.Expressions;

namespace LibraryApplication.Concrete.Repositories
{
    public class CategoryRepository : ICategory
    {
        DataBaseContext c = new DataBaseContext();
         DbSet<Category> _object;

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();

        }

        public List<Category> List()
        {
            return _object.ToList();
        }
        public List<Category>List(Expression<Func<Category,bool>>filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}