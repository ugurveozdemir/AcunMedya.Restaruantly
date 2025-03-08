using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedya.Restaruantly.Entities
{
	public class Message
	{
        public int MessageId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public string IsRead { get; set; }

    }
}