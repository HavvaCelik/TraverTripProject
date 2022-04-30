using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TraverTripProject.Models.Class
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AddressDetail { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string location { get; set; }
    }
}