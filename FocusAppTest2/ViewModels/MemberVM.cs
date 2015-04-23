using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FocusAppTest2.ViewModels
{
    public class MemberVM
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        //public virtual List<CourseVM> MembersCourse { get; private set; }
    }
}