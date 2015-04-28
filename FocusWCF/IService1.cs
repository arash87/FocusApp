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
        bool JoinCourse(long memberId, int courseId);

        [OperationContract]
        bool CancelCourse(long memberId, int courseId);

        [OperationContract]
        Profile GetProfile(long memberId);

        [OperationContract]
        bool UpdateProfile(long memberId, string address, int phone, string birthdate, string fname, string lname, int zip, string city);

        [OperationContract]
        List<AdminModel> GetAdmin();

        [OperationContract]
        Member AddMember(string email, string passwordhash);

        [OperationContract]
        void SetPasswordForMember(int memberId, string passwordhash);

        [OperationContract]
        FacebookMember AddFacebookMember(long facebookid, string accessToken);

        [OperationContract]
        bool UpdateAccessToken(long facebookid, string accessToken);

        [OperationContract]
        List<FacebookMember> GetFacebookMembers();
    }
}
