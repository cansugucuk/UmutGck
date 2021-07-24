//using LibraryApplication.Filter;
using LibraryApplication.Concrete.Repositories;
using LibraryApplication.DbModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryApplication.DbModel.Context;
//using asp_net_ef_codefirst.Models;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using asp_net_ef_codefirst.Context.Managers;
//using asp_net_ef_codefirst.ViewModels;





namespace LibraryApplication.Controllers
{
    //[AuthFilter]
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryTable()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            DataBaseContext context = new DataBaseContext();
            //var test = context.Book.Where(x => x.KisiId == sessiondakiKisi.Id && x.KategoriId == kategoriId).ToList();


            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }
        public ActionResult AddCategory(Category p) //kategori ekleme
        {
            cm.CategoryAdd(p);
            return RedirectToAction("GetCategoryList"); 
        }
    }
}