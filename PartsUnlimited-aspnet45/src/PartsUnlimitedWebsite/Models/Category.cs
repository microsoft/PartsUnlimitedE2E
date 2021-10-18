﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Category
    // categorias
    {
        public int CategoryId { get; set; }
        // cambio

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
        // categoria master
        // un cambio
    }
}