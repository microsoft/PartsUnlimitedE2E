using System;
using System.ComponentModel.DataAnnotations;
// My first change
namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }
// My second change
        public virtual Product Product { get; set; }
    }
}