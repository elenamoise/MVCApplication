using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "University Name")]

        public string City { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}