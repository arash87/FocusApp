using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FocusAppTest2.Controllers
{
    public class ErrorsController : Controller
    {
        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult TestError()
        {
            throw new Exception("ERROR TEST");
        }

    }
}
