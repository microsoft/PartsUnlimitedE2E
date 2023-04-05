using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
<<<<<<< HEAD
        //My Second Change
=======
        //My First Change
>>>>>>> 262ac993372e98271bd948c98d3b1618db637b3f
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