using FocusAppTest2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FocusAppTest2.Helpers;

namespace FocusAppTest2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();      //published
        //ServiceReference2.Service1Client obj = new ServiceReference2.Service1Client();    //localhost

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MemberVM form)
        {
            var member = obj.GetMembers().FirstOrDefault(u => u.email == form.Email);

            //member doesn't exist -> we create and return a new 
            if (member == null) {
                //TODO: serverside checks to validate formdata
                member = AuthHelper.AddNewMember(form);
            }
            //member exists -> add error if password doesn't match
            else if (!AuthHelper.CheckPassword(member, form.Password))
                ModelState.AddModelError("Password", "Password is incorrect");

            if (!ModelState.IsValid)
                return View(form);


            //passed authentication
            FormsAuthentication.SetAuthCookie(member.email, true);
            return RedirectToAction("MyCourses", "Main");

        }
    }
}
