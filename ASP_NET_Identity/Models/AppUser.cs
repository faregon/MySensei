using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace ASP_NET_Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
        public string Summary { get; set; }
        public string Address { get; set; }

        public ICollection<Course> Courses { get; set; }
    }

    }