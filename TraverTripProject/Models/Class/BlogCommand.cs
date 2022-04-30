using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraverTripProject.Models.Class
{
    public class BlogCommand
    {
        public IEnumerable<Blog> item1 { get; set; }
        public IEnumerable<Command> item2 { get; set; }
        public IEnumerable<Blog> item3 { get; set; }
    }
}