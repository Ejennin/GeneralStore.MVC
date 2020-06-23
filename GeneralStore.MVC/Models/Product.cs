using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public int InventoryCount { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool IsFood { get; set; }
    }


}