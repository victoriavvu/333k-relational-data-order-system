using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vu_Victoria_HW5.Models
{
    public class Supplier
    {
        [Display(Name = "Supplier ID")]
        public Int32 SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        [Required(ErrorMessage = "Supplier Name is required.")]
        public String SupplierName { get; set; }

        [Display(Name = "Email")]
        public String SupplierEmail { get; set; }

        [Display(Name = "Phone Number")]
        public String SupplierPhoneNumber { get; set; }

        public List<Product> Products { get; set; }

        public Supplier() 
        {
            if (Products == null)
            {
                Products = new List<Product>();
            }
         }


    }
}
