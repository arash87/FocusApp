﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FocusAppTest2.Helpers
{
    public class RoleProvider : System.Web.Security.RoleProvider
    {
        //SetAuthCookie uses this method, authorize different kinds of users here
        public override string[] GetRolesForUser(string username)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            try
            {
                var m = obj.GetMembers().First(x => x.email == username);
                
                if (m.role == "admin")
                    return new[] {"member", "admin"};

                return new[] { "member" }; // makes it possible to get m.role if we wanna use roles from DB
                //return new[] { "member", m.role };
            }
            // exception -> user is logged in through facebook
            catch (InvalidOperationException)
            {
                return new[] {"member", "facebookmember" };
            }
        }



        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}