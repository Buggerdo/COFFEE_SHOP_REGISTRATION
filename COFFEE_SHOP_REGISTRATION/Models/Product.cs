﻿using System;
using System.Collections.Generic;

namespace COFFEE_SHOP_REGISTRATION.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
    }
}
