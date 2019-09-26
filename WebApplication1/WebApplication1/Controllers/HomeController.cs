using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.AddToastMessage("abc", "Nguyen Thanh Tung" + DateTime.Now.ToShortDateString(), ToastType.Info);

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
        public ActionResult GoSomewhereElse()

        {

            this.AddToastMessage("Redirected message", "This message has been redirected", ToastType.Info);

            return RedirectToAction("Index");

        }
    }
}
