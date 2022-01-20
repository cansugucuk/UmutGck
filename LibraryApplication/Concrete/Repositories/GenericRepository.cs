using LibraryApplication.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Data.Entity;
using LibraryApplication.Concrete.Repositories;
using LibraryApplication.DbModel.Context;

namespace LibraryApplication.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        DataBaseContext c = new DataBaseContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
           
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}