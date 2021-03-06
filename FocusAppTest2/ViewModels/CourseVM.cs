﻿using FocusAppTest2.ServiceReference1;
//using FocusAppTest2.ServiceReference3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FocusAppTest2.ViewModels
{
    public class CourseVM
    {
        public CourseVM(Course c){
            Id = c.id;
            Start = c.startdate;
            End = c.enddate;
            Price = c.price;
            Location = c.location;
            Info = c.info;
            Capacity = c.capacity;
            Name = c.name;
            Address = c.address;
        }
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public string Info { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}