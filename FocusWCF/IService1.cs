﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FocusWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Member> GetMembers();

        [OperationContract]
        List<Profile> GetProfiles();

        [OperationContract]
        List<CourseMember> GetCourseMembers();

        [OperationContract]
        List<Course> GetCourses();

        [OperationContract]
        Member AddMember(string email, string passwordhash);

        [OperationContract]
        void SetPasswordForMember(Member m, string passwordhash);

        [OperationContract]
        void JoinCourse(int memberId, int courseId);

        [OperationContract]
        void LeaveCourse(int memberId, int courseId);
       
    }
}
