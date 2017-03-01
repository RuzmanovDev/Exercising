using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Web.Models
{
    public class PostViewModel
    {
        public string UserName { get; set; }
        [MinLength(2)]
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}