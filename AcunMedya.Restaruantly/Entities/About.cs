using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedya.Restaruantly.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Fitem { get; set; }
        public string Sitem { get; set; }
        public string Titem { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}