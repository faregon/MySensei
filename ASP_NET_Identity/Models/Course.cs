using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySensei.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}