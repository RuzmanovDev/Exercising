using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User : IdentityUser
    {
        private ICollection<Trip> trips;
        private ICollection<User> friends;

        public User()
        {
            this.trips = new HashSet<Trip>();
            this.friends = new HashSet<User>();
        }

        [MinLength(3)]
        [MaxLength(25)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(25)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string AvataImageurl { get; set; }

        [NotMapped]
        public string FullName
        {
            get { return $"{this.FirstName} {this.LastName}"; }
        }

        public virtual ICollection<Trip> Trips
        {
            get { return this.trips; }
            set { this.trips = value; }
        }

        public virtual ICollection<User> Friends
        {
            get { return this.Friends; }
            set { this.Friends = value; }
        }

        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            ClaimsIdentity userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(this.GenerateUserIdentity(manager));
        }

        public static SchoolSystemDbContext Create()
        {
            return new SchoolSystemDbContext();
        }
    }
}
