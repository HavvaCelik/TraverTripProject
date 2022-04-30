using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TraverTripProject.Models.Class
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string imgUrl { get; set; }
        public string Description { get; set; }
    }
}