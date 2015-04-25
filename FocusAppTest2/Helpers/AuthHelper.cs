using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using FocusAppTest2.ServiceReference1;      //published
using FocusAppTest2.ServiceReference2;    //localhost

namespace FocusAppTest2.Helpers
{
    public class AuthHelper
    {

        // Hashes input password with salt and a workload of 13
        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 13);
        }
        
        // Set a new password for an existing member
        public static void SetPassword(int memberId, string password)
        {
            Service1Client obj = new Service1Client();            
            obj.SetPasswordForMember(memberId, HashPassword(password));
        }

        // Verifies the input password against a members existing one
        public static bool CheckPassword(Member m, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, m.password);
        }

        // Adds a new member to the DB with data from a viewmodel and returns it
        public static Member AddNewMember(ViewModels.MemberVM newMember)
        {
            Service1Client obj = new Service1Client();
            return obj.AddMember(newMember.Email, HashPassword(newMember.Password));
        }
    }
}