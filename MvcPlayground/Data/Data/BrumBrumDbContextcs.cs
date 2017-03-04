using Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class BrumBrumDbContextcs : IdentityDbContext<User>
    {
        public static BrumBrumDbContextcs Create()
        {
            return new BrumBrumDbContextcs();
        }


        public BrumBrumDbContextcs( ) 
            : base("BrumBrum")
        {
        }

        public virtual IDbSet<City> Cities { get; set; }

        public virtual IDbSet<DriverReview> DriverReviews { get; set; }

        public virtual IDbSet<Trip> Trips { get; set; }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
        }
    }
}
