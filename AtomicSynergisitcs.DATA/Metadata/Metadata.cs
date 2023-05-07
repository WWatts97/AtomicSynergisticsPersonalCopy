using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicSynergisitcs.DATA.Models/*.Metadata*/
{
    public class CountryMetadata
    {
        public int CountryId { get; set; }

        [Required]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Country")]
        [StringLength(100)]
        public string CountryName { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Region")]
        public int? RegionId { get; set; }
    }
    public class CustomerMetadata
    {
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Customer")]
        [StringLength(150)]
        public string CustomerName { get; set; } = null!;

        [Required]
        [Display(Name = "Contact")]
        [StringLength(75)]
        public string ContactName { get; set; } = null!;

        [Required]
        [Display(Name = "Contact Phone")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhone { get; set; } = null!;

        [Required]
        [Display(Name = "Contact Email")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; } = null!;

        [Required]
        [Display(Name = "Billing Address")]
        [StringLength(100)]
        public string BillingAddress { get; set; } = null!;

        [Required]
        [Display(Name = "Billing City")]
        [StringLength(100)]
        public string BillingCity { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Billing State")]
        [StringLength(2)]
        public string? BillingState { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Billing Postal Code")]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string? BillingPostalCode { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryId { get; set; }
    }
    public class DepartmentMetadata
    {
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "Department")]
        [StringLength(150)]
        public string DepartmentName { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Location")]
        public int? LocationId { get; set; }
    }
    public class EmployeeMetadata
    {
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(100)]
        public string? Position { get; set; }


        [DataType(DataType.Currency)]
        [Range(0, (double)decimal.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        public decimal? Salary { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [DataType(DataType.Date)]
        [Display(Name = "Termination Date")]
        public DateTime? TerminationDate { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(100)]
        public string? Address { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(100)]
        public string? City { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(2)]
        public string? State { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Country")]
        public int? CountryId { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Manager")]
        public int? ManagerId { get; set; }
    }
    public class LocationMetadata
    {
        public int LocationId { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(100)]
        public string LocationAddress { get; set; } = null!;

        [Required]
        [Display(Name = "City")]
        [StringLength(100)]
        public string LocationCity { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "State")]
        [StringLength(2)]
        public string? LocationState { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Postal Code")]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        public string? LocationPostalCode { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Country")]
        public int? CountryId { get; set; }
    }
    public class OrderMetadata
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(50)]
        [Display(Name = "Purchase Order Number")]
        public string? Ponumber { get; set; }

        [Required]
        [Display(Name = "Vendor")]
        public int VendorId { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "$0.00")]
        [Display(Name = "Order Total")]
        [DataType(DataType.Currency)]
        [Range(0, (double)decimal.MaxValue)]
        public decimal? OrderTotal { get; set; }
    }
    public class OrderProductMetadata
    {
        public int OrderProductId { get; set; }

        [Required]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public short OrderQuantity { get; set; }
    }
    public class ProductMetadata
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product")]
        [StringLength(150)]
        public string ProductName { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(int.MaxValue)]
        public string? Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        [Range(0, (double)decimal.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Cost Per Unit")]
        public decimal? CostPerUnit { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "[N/A]")]
        [Range(0, (double)decimal.MaxValue)]
        [DataType(DataType.Currency)]
        [Display(Name = "Price Per Unit")]
        public decimal? PricePerUnit { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Unit Type")]
        [StringLength(50)]
        public string? UnitType { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Units In Stock")]
        [Range(0, short.MaxValue)]
        public short? UnitsInStock { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Units On Order")]
        [Range(0, short.MaxValue)]
        public short? UnitsOnOrder { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Status")] 
        public int? ProductStatusId { get; set; }

        [Required]
        [Display(Name = "Type")]
        public int ProductTypeId { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Vendor")]
        public int? VendorId { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Display(Name = "Image")]   
        [StringLength(100)]
        public string? ProductImage { get; set; }
    }
    public class ProductStatusMetadata
    {
        public int ProductStatusId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Product Status")]
        public string ProductStatusName { get; set; } = null!;
    }
    public class ProductTypeMetadata
    {
        public int ProductTypeId { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Product Type")]
        public string ProductTypeName { get; set; } = null!;
    }
    public class RegionMetadata
    {
        public int RegionId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Region")]
        public string RegionName { get; set; } = null!;
    }
    public class SaleMetadata
    {
        [Display(Name = "Sale ID")]
        public int SaleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Sales Date")]
        public DateTime SaleDate { get; set; }

        [Required]
        [Display(Name = "Salesperson")]
        public int SalespersonId { get; set; }

        [Required]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = true, NullDisplayText = "0.00")]
        [DataType(DataType.Currency)]
        [Range(0, (double)decimal.MaxValue)]
        [Display(Name = "Sale Total")]
        public decimal? SaleTotal { get; set; }
    }
    public class SaleProductMetadata
    {
        public int SaleProductId { get; set; }

        [Required]
        [Display(Name = "Sale ID")]
        public int SaleId { get; set; }

        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        [Range(0, short.MaxValue)]
        public short SaleQuantity { get; set; }
    }
    public class VendorMetadata
    {
        public int VendorId { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [Required]
        [StringLength(150)]
        [Display(Name = "Vendor")]
        public string VendorName { get; set; } = null!;

        [Required]
        [StringLength(75)]
        [Display(Name = "Contact")]
        public string VendorContact { get; set; } = null!;

        [Required]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string VendorPhone { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string VendorEmail { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string VendorAddress { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Display(Name = "City")]
        public string VendorCity { get; set; } = null!;

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(2)]
        [Display(Name = "State")]
        public string? VendorState { get; set; }

        [DisplayFormat(NullDisplayText = "[N/A]")]
        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public string? VendorPostalCode { get; set; }

        [Display(Name = "Country")]
        public int CountryId { get; set; }
    }

}
