using LibraryApplication.DbModel.Context;
using LibraryApplication.DbModel.Entity;
using LibraryApplication.Models.Login;
using System.Linq;
using System.Web.Mvc;


namespace LibraryApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

            //kodlarım 
        public ActionResult Login()
        {

            return View("~/Views/Login/Login.cshtml");
        }


        //kodlarım 
        //[HttpGet]
        //public ActionResult Create([Bind(Include = "UserName,Password")] UserType userType)
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username,Password")]Admin model)
        {
            DataBaseContext dbContext = new DataBaseContext();

            var user = dbContext.Admins.FirstOrDefault(p=>p.Username == model.Username && p.Password == model.Password);
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

        //[HttpGet]
        //public ActionResult LoginGiris([Bind(Include = "UserName,Password")]User model)
        //{
        //    DataBaseContext dbContext = new DataBaseContext();

        //    var user = dbContext.Users.FirstOrDefault(p => p.UserName == model.UserName && p.Password == model.Password);
        //    if (user == null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        Session["LoginUser"] = user;
        //        return RedirectToAction("Index", "Home");
        //    }
        //}

    }
}