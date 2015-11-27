using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySensei.Models
{
    public class Instructor : AppUser
    {
        public Instructor() : base() { }
        public string Summary { get; set; }
        public string Education { get; set; }
    }
}