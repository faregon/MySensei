using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ASP_NET_Identity.Models;
using Microsoft.AspNet.Identity;
using System.Collections;

namespace ASP_NET_Identity.Infrastructure
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext() : base("IdentityDb") { }

      


        static AppIdentityDbContext()
        {
            Database.SetInitializer<AppIdentityDbContext>(new IdentityDbInit());
        }

        public static AppIdentityDbContext Create()
        {
            return new AppIdentityDbContext();
        }
        public IEnumerable AppUser { get; set; }
        
    }

    public class IdentityDbInit : NullDatabaseInitializer<AppIdentityDbContext>
    {
    }
}