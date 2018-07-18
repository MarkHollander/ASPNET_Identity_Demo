using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;


namespace WebApplication_MVC.Models
{
    public class AnCaDB2: IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateAnCaDB2IdentityAsync(UserManager<AnCaDB2> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class AnCaDB2DbContext : IdentityDbContext<AnCaDB2>
    {
        public AnCaDB2DbContext() : base("AnCaDB2", throwIfV1Schema: false) { }

        public static AnCaDB2DbContext Create()
        {
            return new AnCaDB2DbContext();
        }
    }
}