using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace ASP_NET_Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
<<<<<<< HEAD
        public string City { get; set; }
        public DateTime BirthDay { get; set; }
=======
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
        public string Summary { get; set; }
        public string Address { get; set; }
>>>>>>> c6e697e03589352d4121255a25c28f89526db8cf

        public ICollection<Course> Courses { get; set; }
    }

    }