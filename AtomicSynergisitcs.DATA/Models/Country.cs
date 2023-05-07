 using System;
using System.Collections.Generic;

namespace AtomicSynergisitcs.DATA.Models
{
    public partial class Country
    {
        public Country()
        {
            Customers = new HashSet<Customer>();
            Locations = new HashSet<Location>();
            Vendors = new HashSet<Vendor>();
            Employees = new HashSet<Employee>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public int? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
