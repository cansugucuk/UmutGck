using LibraryApplication.Concrete.Repositories;
using LibraryApplication.DbModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApplication.Proces
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAdd(Category p)
        {
            if(p.CategoryName== "" || p.CategoryName.Length<=3 ||p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
                 
            }
        }
    }
}