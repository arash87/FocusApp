//using FocusAppTest2.ServiceReference1;
using FocusAppTest2.ServiceReference3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FocusAppTest2.ViewModels;

namespace FocusAppTest2.Controllers
{
    [Authorize(Roles="member")]
    public class MainController : Controller
    {
        Service1Client obj = new Service1Client();
        

        public ActionResult Courses()
        {
            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            List<Course> filter;

            // prøve vanlig medlem
            try
            {
                var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
                filter = (from course in courses
                                       join cm in courseMember on course.id equals cm.courseId
                                       where cm.memberId == currentMember.id
                                       select course).ToList();

            } //exception -> medlem innlogget via facebook
            catch (InvalidOperationException)
            {
                var currentMember = obj.GetFacebookMembers().First(x => x.facebookid.ToString() == User.Identity.Name);
                filter = (from course in courses
                                       join cm in courseMember on course.id equals cm.courseId
                                       where cm.memberId == currentMember.facebookid
                                       select course).ToList();
            }
            var removeDuplicates = courses.Except(filter);
            var choosenCourses = from course in removeDuplicates
                                 select new CourseVM(course);
            return View(choosenCourses);
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

            return View(chosenCourses.ToList());
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
            catch(InvalidOperationException)
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

        [HttpPost]
        public ActionResult UpdateProfile(long id, string address, int phone, string birthdate, string fname, string lname, int zip, string city)
        {
            bool updated = obj.UpdateProfile(id, address, phone, birthdate, fname, lname, zip, city);
            Profile profile = obj.GetProfile(id);
            return View("Profile", profile);
        }

        public ActionResult Contact()
        {
            List<AdminModel> adminList = obj.GetAdmin().ToList();
            return View(adminList);
        }
    }
}
