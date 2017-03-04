using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Trip
    {
        private ICollection<User> passangers;

        public Trip()
        {
            this.passangers = new HashSet<User>();
        }

        public int Id { get; set; }

        [ForeignKey("Driver")]
        public string DriverId { get; set; }

        public virtual User Driver { get; set; }

        public virtual ICollection<User> Passangers
        {
            get { return this.passangers; }
            set { this.passangers = value; }
        }

        public decimal Price { get; set; }

        public int Seats { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public DateTime Date { get; set; }

        public virtual City Origin { get; set; }

        [ForeignKey("Origin")]
        public int OriginId { get; set; }

        public virtual City Destination { get; set; }

        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
    }
}
