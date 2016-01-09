using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel;
using Repository;

namespace WebApplication4.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Subscribe()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SaveData(MemberData data)
        {

            new MemberRepository().saveData(data);
            return Json("success",JsonRequestBehavior.DenyGet);
        }
    }

    
}