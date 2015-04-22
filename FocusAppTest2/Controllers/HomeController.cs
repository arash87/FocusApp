using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FocusAppTest2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

        public ActionResult Index()
        {
            return View();
        }


    }
}
