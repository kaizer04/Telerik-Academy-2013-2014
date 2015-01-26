using EasyPTC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyPTC.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IEasyPtcData data)
            :base(data)
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}