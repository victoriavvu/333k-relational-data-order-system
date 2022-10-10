using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vu_Victoria_HW5.Models
{
    public class AppUser : IdentityUser
    {
        //TODO: Add additional user fields here
        //First name is provided as an example
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name ="Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        public List<Order> Orders { get; set; }
        public AppUser()
        {
            if (Orders == null)
            { 
                Orders = new List<Order>(); 
            }
        }
    }
}
