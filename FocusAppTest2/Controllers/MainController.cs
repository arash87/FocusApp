using FocusAppTest2.ServiceReference1;
//using FocusAppTest2.ServiceReference3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FocusAppTest2.ViewModels;

namespace FocusAppTest2.Controllers
{
    [Authorize(Roles = "member")]
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class MainController : Controller
    {
        Service1Client obj = new Service1Client();

        [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
        public ActionResult Courses(string city = null)
        {
            if (city == null)
            {
                city = "";
            }

            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            long currentMember;

            // prøve vanlig medlem
            try
            {
                currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name).id;

            } //exception -> medlem innlogget via facebook
            catch (InvalidOperationException)
            {
                currentMember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name).facebookid;
            }

            List<Course> filter = (from course in courses
                                   join cm in courseMember on course.id equals cm.courseId
                                   where cm.memberId == currentMember
                                   select course).ToList();
            var removeDuplicates = courses.Except(filter);
            var choosenCourses = from course in removeDuplicates
                                 select new CourseVM(course);
            if (!city.Equals(""))
            {
                choosenCourses = from course in removeDuplicates
                                 where course.location == city
                                 select new CourseVM(course);
                ViewBag.Title = city;
            }
            return View(choosenCourses.OrderBy(x => x.Start.Date));
        }
        public ActionResult MyCourses()
        {
            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            IEnumerable<CourseVM> chosenCourses;

            // prøve vanlig medlem
            try
            {
                var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
                chosenCourses = from course in courses
                                join cm in courseMember on course.id equals cm.courseId
                                where cm.memberId == currentMember.id
                                select new CourseVM(course);

            } // exception -> medlem innlogget via facebook
            catch (InvalidOperationException)
            {
                var currentMember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name);
                chosenCourses = from course in courses
                                join cm in courseMember on course.id equals cm.courseId
                                where cm.memberId == currentMember.facebookid
                                select new CourseVM(course);
            }

            return View(chosenCourses.ToList().OrderBy(x => x.Start.Date));
        }

        public ActionResult Category()
        {
            return View();
        }

        [HttpPost]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult Join(int id)
        {
            try
            {
                var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
                bool isSuccessful = obj.JoinCourse(currentMember.id, id);
            }
            catch (InvalidOperationException)
            {
                var currentMember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name);
                bool isSuccessful = obj.JoinCourse(currentMember.facebookid, id);
            }
            // Try Catch & If
            if (!Request.IsAjaxRequest())
                return RedirectToAction("Course");
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult Cancel(int id)
        {
            try
            {
                var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
                bool isDeleted = obj.CancelCourse(currentMember.id, id);     // Try Catch & If
            }
            catch (InvalidOperationException)
            {
                var currentMember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name);
                bool isDeleted = obj.CancelCourse(currentMember.facebookid, id);
            }

            if (!Request.IsAjaxRequest())
                return RedirectToAction("MyCourses");
            return PartialView("_CurrentStatus");
        }

        public ActionResult Profile()
        {
            Profile profile;
            try
            {
                var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
                profile = obj.GetProfile(currentMember.id);
            }
            catch (InvalidOperationException)
            {
                var currentMember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name);
                profile = obj.GetProfile(currentMember.facebookid);
            }

            DateTime birthday;
            string stringDate;
            if (profile.birthdate != null)
            {
                birthday = (DateTime)profile.birthdate;
                stringDate = birthday.ToString("yyyy-MM-dd");
            }
            else
            {
                stringDate = "";
            }
            ViewBag.Data1 = stringDate;
            return View(profile);
        }

        public ActionResult ProfileMenu()
        {
            FacebookMember fbmember;
            Profile profile;
            Member currentMember = obj.GetMembers().FirstOrDefault(x => x.email == User.Identity.Name);

            if (currentMember != null)
                profile = obj.GetProfiles().First(x => x.memberId == currentMember.id);
            else
            {
                fbmember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name);
                profile = obj.GetProfiles().First(x => x.memberId == fbmember.facebookid);
            }
            return View(profile); // sørg for å returnere profile til viewet for logout/delete
        }

        public ActionResult Contact()
        {
            List<AdminModel> adminList = obj.GetAdmin().ToList();
            return View(adminList);
        }

        [HttpPost]
        public ActionResult UpdateFName(long memberId, string firstName)
        {
            bool isUpdated = obj.UpdateFirstName(memberId, firstName);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        public ActionResult UpdateLName(long memberId, string lastname)
        {
            bool isUpdated = obj.UpdateLastName(memberId, lastname);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        public ActionResult UpdateAddress(long memberId, string address)
        {
            bool isUpdated = obj.UpdateAddress(memberId, address);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        public ActionResult UpdateZip(long memberId, int zip)
        {
            bool isUpdated = obj.UpdateZip(memberId, zip);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        public ActionResult UpdateCity(long memberId, string city)
        {
            bool isUpdated = obj.UpdateCity(memberId, city);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        public ActionResult UpdatePhone(long memberId, int phone)
        {
            bool isUpdated = obj.UpdatePhone(memberId, phone);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        public ActionResult UpdateBirthdate(int memberId, string birthdate)
        {
            bool isUpdated = obj.UpdateBirthday(memberId, birthdate);
            if (!Request.IsAjaxRequest())
            {
                Profile profile = obj.GetProfile(memberId);
                return RedirectToAction("Profile", profile);
            }
            return PartialView("_CurrentStatus");
        }
    }
}
