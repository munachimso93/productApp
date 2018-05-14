using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual Category Category { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }



    }
}