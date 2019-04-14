using SummerScool.DAL;
using SummerScool.DAL.DbModels;
using SummerScool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SummerScool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserRepository user = new UserRepository();
            user.GetUserById(Guid.NewGuid());
                
            return View();
        }

   
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoginWithUser()
        {
            return View("Index");
        }
    }
}