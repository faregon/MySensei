using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASP_NET_Identity.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}