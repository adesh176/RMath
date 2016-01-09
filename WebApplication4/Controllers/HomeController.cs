using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.ServiceReference1;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                //MyData data = new MyData();
                //data.i = 100;
                //data.j = 30;

                //Service1Client client = new Service1Client();
                //int kk = client.add(data);

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

        public ActionResult Pooja()
        {
            ViewBag.Message = "Your pooja page.";

            return View();
        }

        public JsonResult getdata() {
            return Json("test", JsonRequestBehavior.AllowGet);
        }
    }
}