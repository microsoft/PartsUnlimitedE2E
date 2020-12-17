using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
<<<<<<< HEAD
    // This is my First Change
=======
    //My First Change Hhhhhh
>>>>>>> 10a569ac35fb66d85aa0c521deb130ed54a4975e
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}