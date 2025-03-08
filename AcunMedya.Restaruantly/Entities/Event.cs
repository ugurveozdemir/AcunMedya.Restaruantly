using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedya.Restaruantly.Entities
{
	public class Event
	{
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Description2 { get; set; }
        public string Price { get; set; }

    }
}