using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
        //Mi segundo cambio
        //Este cambio realizado en GitHub debe verse en el repositorio ya que se va a utilizar el comando Git Fetch Prune 
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
