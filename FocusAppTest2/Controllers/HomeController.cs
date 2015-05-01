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
                return RedirectToAction("Profile", "Main");
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
            var member = obj.GetMembers().FirstOrDefault(x => x.email == form.Email);

            //if email or password is not provided properly, return right away
            if (!ModelState.IsValid)
                return View(form);

            //member doesn't exist -> we create and return a new
            if (member == null) {
                member = AuthHelper.AddNewMember(form);
            }

            //member exists -> add error if password doesn't match
            else if (!AuthHelper.CheckPassword(member, form.Password))
                ModelState.AddModelError("Password", "There's an account using that email with a different password");

            //last check to see if the form is still valid
            if (!ModelState.IsValid)
                return View(form);


            //passed authentication
            FormsAuthentication.SetAuthCookie(member.email, true);
            return RedirectToAction("Profile", "Main");
        }

        [Authorize(Roles="member")]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "member")]
        [HttpPost]
        public ActionResult DeleteUser(FocusAppTest2.ServiceReference1.Profile profile)
        {
            obj.DeleteMember(profile.memberId);
            return RedirectToAction("Logout");
        }

        public ActionResult DeleteUser()
        {
            return RedirectToAction("Index");
        }
    }
}
