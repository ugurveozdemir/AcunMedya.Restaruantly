﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedya.Restaruantly.Entities
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}