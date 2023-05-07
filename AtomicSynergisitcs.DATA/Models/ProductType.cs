﻿using System;
using System.Collections.Generic;

namespace AtomicSynergisitcs.DATA.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
