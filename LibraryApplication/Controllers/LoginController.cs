using LibraryApplication.DbModel.Context;
using LibraryApplication.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LibraryApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

            //kodlarım 
        public ActionResult Login()
        {

            return View();
        }


        //kodlarım 
        [HttpGet]
        public ActionResult LoginGiris(LoginViewModel model)
        {
            DatabaseContext dbContext = new DatabaseContext();

            var user = dbContext.Users.FirstOrDefault(p=>p.UserName == model.UserName && p.Password == model.Password);
            if (user == null)
            {
                return View();
            }
            else
            {
                Session["LoginUser"] = user;
                return RedirectToAction("Index", "Home");
            }
        }

    }
}