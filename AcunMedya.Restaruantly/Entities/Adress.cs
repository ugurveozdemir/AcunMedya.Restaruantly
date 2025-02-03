using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedya.Restaruantly.Entities
{
    public class Adress
    {
        public int AdressId { get; set; }
        public string Location { get; set; }
        public string OpenHours { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
    }
}