﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedya.Restaruantly.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}