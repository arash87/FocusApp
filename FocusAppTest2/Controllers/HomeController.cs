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
        //ServiceReference3.Service1Client obj = new ServiceReference3.Service1Client();    //localhost


        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToAction("MyCourses", "Main");
            }
            else
            {
                return View();
            }
            
        }

        [HttpPost]
        public JsonResult FacebookLogin(FacebookLoginVM model)
        {
            var fbmember = obj.GetFacebookMembers().FirstOrDefault(x => x.facebookid == model.uid);

            //hvis ikke brukeren har vært i systemet vårt før, lag fbmember 
            if (fbmember == null)
            {
                fbmember = obj.AddFacebookMember(model.uid, model.accessToken);
            }
            else
            {
                obj.UpdateAccessToken(fbmember.facebookid, model.accessToken);
            }

            // logg bruker inn i vårt system
            FormsAuthentication.SetAuthCookie(fbmember.facebookid.ToString(), true);
            return Json(new { success = true });
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

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}
