﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [Display(Name="FirstName")]
        public string FirtName { get; set; }

        [Required]
        [Display(Name="LastName")]
        public string LastName { get; set; }

        [Display(Name ="FullName")]
        public string FullName { get; }
    }
}