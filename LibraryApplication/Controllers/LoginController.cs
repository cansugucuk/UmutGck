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
        public ActionResult LoginGiris()
        {
            //home sayfasının içerisi tasarlancak home.cshtml sayfasında kod yaz tasarla + home

            return View("~/Views/Home/Home.cshtml");
        }

    }
}