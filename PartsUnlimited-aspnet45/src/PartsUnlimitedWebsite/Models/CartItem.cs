using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    //Hello changes Start
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
//Hello changes END
        public virtual Product Product { get; set; }
    }
}