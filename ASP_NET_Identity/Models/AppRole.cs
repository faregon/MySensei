using Microsoft.AspNet.Identity.EntityFramework;

namespace ASP_NET_Identity.Models
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base() { }
        public AppRole(string name) : base(name) { }
    }
}