using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_Identity.Models
{
    public class Instructor : AppUser
    {
        public Instructor() : base() { }
        public string Summary { get; set; }
        public string Education { get; set; }
    }
}