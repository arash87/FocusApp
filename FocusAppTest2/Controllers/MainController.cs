using FocusAppTest2.ServiceReference1;
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
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
        

        public ActionResult Courses()
        {
            var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            List<Course> filter = (from course in courses
                         join cm in courseMember on course.id equals cm.courseId
                         where cm.memberId == currentMember.id
                         select course).ToList();
            var removeDuplicates = courses.Except(filter);

            var choosenCourses = from course in removeDuplicates
                                            select new CourseVM(course);
            return View(choosenCourses);
        }

        public ActionResult MyCourses()
        {
            var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            var filter = from course in courses
                         join cm in courseMember on course.id equals cm.courseId
                         where cm.memberId == currentMember.id
                         select new CourseVM(course);
            List<CourseVM> choosenCourses = filter.ToList();

            return View(choosenCourses);
        }

        [HttpPost]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult Join(int id)
        {
            var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
            bool isSuccessful = obj.JoinCourse(currentMember.id, id);    // Try Catch & If
            if (!Request.IsAjaxRequest())
                return RedirectToAction("Course");
            return PartialView("_CurrentStatus");
        }

        [HttpPost]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public ActionResult Cancel(int id)
        {
            var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
            bool isDeleted = obj.CancelCourse(currentMember.id, id);     // Try Catch & If
            if (!Request.IsAjaxRequest())
                return RedirectToAction("MyCourses");
            return PartialView("_CurrentStatus");
        }

        public ActionResult Profile()
        {
            var currentMember = obj.GetMembers().First(x => x.email == User.Identity.Name);
            Profile profile = obj.GetProfile(currentMember.id);
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
        public ActionResult UpdateProfile(int id, string address, int phone, string birthdate, string fname, string lname, int zip, string city)
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

        [HttpPost]
        public ActionResult Courses(CourseVM selectedCourse)
        {
            return Content("valgt: " + selectedCourse.Name);
            //return RedirectToAction("Courses");
        }

        [HttpPost]
        public ActionResult MyCourses(CourseVM selectedCourse)
        {
            return Content("meldt deg av: " + selectedCourse.Name);
            //return RedirectToAction("MyCourses");
        }



    }
}
