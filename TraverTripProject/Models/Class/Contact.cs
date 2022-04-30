﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TraverTripProject.Models.Class
{
    public class Contact
    { 
        [Key]
        public int ID { get; set; }

       
        public string NameSurname { get; set; }
        
        public string Email { get; set; }
     
        public string issue { get; set; }
       
        public string Message { get; set; }
    }
}