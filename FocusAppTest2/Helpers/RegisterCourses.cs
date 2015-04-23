using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FocusAppTest2.ServiceReference1;      //published
//using FocusAppTest2.ServiceReference2;      //localhost

namespace FocusAppTest2.Helpers
{
    public class RegisterCourses
    {
        public static void JoinCourse(int memberId, int courseId)
        {
            Service1Client obj = new Service1Client();
            obj.JoinCourse(memberId, courseId);
        }

        public static void LeaveCourse(int memberId, int courseId)
        {
            Service1Client obj = new Service1Client();
            obj.LeaveCourse(memberId, courseId);
        }
    }
}