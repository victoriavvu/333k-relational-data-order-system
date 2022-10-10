using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Vu_Victoria_HW5.Models
{
    public enum ProductType { Hot, Cold, Packaged, Drink, Other }
    public class Product
    {
        [Display(Name = "Product ID")]
        public Int32 ProductID { get; set; }

        [Display(Name = "Product Name:")]
        [Required(ErrorMessage = "Product name is required!")]
        public String ProductName { get; set; }

        [Display(Name = "Product Description:")]
        public String Description { get; set; }

        [Display(Name = "Product Price:")]
        [Required(ErrorMessage = "Product price is required!")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Price { get; set; }

        [Display(Name = "Product Type:")]
        public ProductType Types { get; set; }

        public List<Supplier> Suppliers { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Product()
        {
            if (Suppliers == null)
            {
                Suppliers = new List<Supplier>();
            }

            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }

    }
}
