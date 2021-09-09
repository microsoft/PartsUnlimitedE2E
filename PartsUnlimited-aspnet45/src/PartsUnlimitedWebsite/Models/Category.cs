using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
//category chage issues #1
// My third change
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}