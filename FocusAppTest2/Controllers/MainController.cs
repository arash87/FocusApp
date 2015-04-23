﻿using FocusAppTest2.ServiceReference1;
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
        //
        // GET: /Main/

        public ActionResult Course()
        {
            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            List<Course> filter = (from course in courses
                         join cm in courseMember on course.id equals cm.courseId
                         where cm.memberId == 1
                         select course).ToList();
            var removeDuplicates = courses.Except(filter);

            var choosenCourses = from course in removeDuplicates
                                            select new CourseVM(course);
            return View(choosenCourses);
        }

        public ActionResult MyCourses()
        {
            List<Course> courses = obj.GetCourses().ToList();
            List<CourseMember> courseMember = obj.GetCourseMembers().ToList();
            var filter = from course in courses
                         join cm in courseMember on course.id equals cm.courseId
                         where cm.memberId == 1
                         select new CourseVM(course);
            List<CourseVM> choosenCourses = filter.ToList();

            return View(choosenCourses);
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Join()
        {
            if (!Request.IsAjaxRequest())
                return RedirectToAction("Course");

            return PartialView("_CurrentButton");
        }
    }
}