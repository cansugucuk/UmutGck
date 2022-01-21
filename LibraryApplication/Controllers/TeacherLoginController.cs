using LibraryApplication.DbModel.Context;
using LibraryApplication.DbModel.Entity;
using LibraryApplication.Models.Login;
using System.Linq;
using System.Web.Mvc;


namespace LibraryApplication.Controllers
{
    public class TeacherLoginController : Controller
    {
        // GET: Login

            //kodlarım 
        public ActionResult Login()
        {

            return View("~/Views/Login/TeacherLogin/TeacherLogin.cshtml");
        }


        //kodlarım 
        //[HttpGet]
        //public ActionResult Create([Bind(Include = "UserName,Password")] UserType userType)
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username,Password")]Admin model)
        {
            DataBaseContext dbContext = new DataBaseContext();

            var user = dbContext.Teachers.FirstOrDefault(p=>p.Username == model.Username && p.Password == model.Password);
            if (user == null)
            {
                return View("~/Views/Login/Error.cshtml");
            }
            else
            {
                Session["LoginUser"] = user;
                return RedirectToAction("Index", "Home");
            }
        }


    }
}