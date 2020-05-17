using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Category
    {
<<<<<<< HEAD
        //Testing , pull request.002
=======
>>>>>>> b5eaa596236a12599bdc1c7575f66fdd1d9991ba
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}