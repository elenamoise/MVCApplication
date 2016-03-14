﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UniversityId { get; set; }

        public string Address { get; set; }

        public int YearOfStudy { get; set; }
        public University University { get; set; }
    }
}