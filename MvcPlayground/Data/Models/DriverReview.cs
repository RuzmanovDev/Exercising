using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DriverReview
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(300)]
        public string Content { get; set; }

        public virtual User Reviewer { get; set; }

        [ForeignKey("Reviewer")]
        public int ReviewerId { get; set; }
    }
}
