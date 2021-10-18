using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
        // Mas y mas cambios en GitHub.. para aprender
        // otro cambio a manufactures
        // manufactures desde dev2, 
    }
}