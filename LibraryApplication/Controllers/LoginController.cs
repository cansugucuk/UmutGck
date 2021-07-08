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

        public ActionResult UserAndPasswordControl(string userName, string password) // 1.username ve passwordu ekranda geirilen değerlerden çek
        {
            //2. user tablosunda kullanıcı ve şifresi varsa yeni saYFAYA yönlendir
            //yoksa hata mesajı ver. kullanıcı adı şifre hatalıdır diye
            Console.WriteLine(userName + "  " + password);
            return View();
        }
    }
}