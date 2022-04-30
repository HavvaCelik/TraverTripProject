using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TraverTripProject.Models.Class
{
    public class Command
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Commands { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }


    }
}