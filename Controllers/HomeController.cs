using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task22_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUniqueNumbers(string Number)
        {
            string uniqueNumber = "";
            for (int i = 0; i < Number.Length; i++)
            {
                if (uniqueNumber.Contains(Number[i].ToString()))
                {
                    continue;
                }
                uniqueNumber += Number[i];
            }
            
            return Json(uniqueNumber, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}