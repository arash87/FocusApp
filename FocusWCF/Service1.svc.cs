using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FocusWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DbClassesDataContext dx = new DbClassesDataContext();

        public List<Member> GetMembers()
        {
            return dx.Members.ToList();
        }

        public List<Profile> GetProfiles()
        {
            return dx.Profiles.ToList();
        }

        public List<CourseMember> GetCourseMembers()
        {
            return dx.CourseMembers.ToList();
        }

        public List<Course> GetCourses()
        {
            return dx.Courses.ToList();
        }
        public bool JoinCourse(int mId, int cId)
        {
            CourseMember cm = new CourseMember { memberId = mId, courseId = cId };
            dx.CourseMembers.InsertOnSubmit(cm);
            dx.SubmitChanges();
            return true;
        }


        public bool CancelCourse(int mId, int cId)
        {
            CourseMember cm = (from course in dx.CourseMembers
                               where course.memberId == mId && course.courseId == cId
                               select course).First();
            dx.CourseMembers.DeleteOnSubmit(cm);
            dx.SubmitChanges();
            return true;
        }


        public Profile GetProfile(int memberId)
        {
            Profile memberProfile = (from profile in dx.Profiles
                                     where profile.memberId == memberId
                                     select profile).First();
            return memberProfile;
        }

        public bool UpdateProfile(int memberId, string address, int phone, string birthdate, string fname, string lname, int zip, string city)
        {
            DateTime chosenDate = DateTime.ParseExact(birthdate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime initialValue = new DateTime(2015, 04, 24);
            Profile memberProfile = (from profile in dx.Profiles
                                     where profile.memberId == memberId
                                     select profile).First();
            memberProfile.address = address;
            memberProfile.phone = (phone == 0) ? (int?)null : phone;
            memberProfile.birthdate = (chosenDate.Date == initialValue.Date) ? (DateTime?)null : chosenDate.Date;
            memberProfile.zip = (zip == 0) ? (int?)null : zip;
            memberProfile.city = city;
            memberProfile.firstname = fname;
            memberProfile.lastname = lname;
            dx.SubmitChanges();
            return true;
        }


        public List<AdminModel> GetAdmin()
        {
            List<AdminModel> admins = (from profile in dx.Profiles
                                       join member in dx.Members on profile.memberId equals member.id
                                       where member.role.Equals("admin")
                                       select new AdminModel
                                       {
                                           Fname = profile.firstname,
                                           Lname = profile.lastname,
                                           Email = member.email,
                                           Phone = (int)profile.phone
                                       }).ToList();

            return admins;
        }


        public Member AddMember(string email, string passwordhash)
        {
            Member newMember = new Member();
            newMember.email = email;
            newMember.password = passwordhash;
            dx.Members.InsertOnSubmit(newMember);
            dx.SubmitChanges();
            return dx.Members.First(x => x.email == newMember.email);
        }

        public void SetPasswordForMember(int memberId, string passwordhash)
        {
            Member member = dx.Members.First(x => x.id == memberId);
            member.password = passwordhash;
            dx.SubmitChanges();
        }
    }
}
