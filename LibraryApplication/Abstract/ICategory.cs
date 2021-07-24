using LibraryApplication.DbModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Abstract
{
    public interface ICategory
    {
        //crud
        List<Category> List();

        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);
    }
}
