using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TraverTripProject.Models.Class
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImg { get; set; }
        
        public ICollection<Command> Commands { get; set; }
    }
}