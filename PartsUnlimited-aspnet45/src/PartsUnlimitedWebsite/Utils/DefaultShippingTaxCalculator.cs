using PartsUnlimited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartsUnlimited.Utils
{
	public class DefaultShippingTaxCalculator : IShippingTaxCalculator
	{
		public OrderCostSummary CalculateCost(List<OrderDetail> orderDetails, string postalCode)
		{
			var subTotal = orderDetails.Sum(x => x.Quantity * x.Product.Price);
			var itemsCount = orderDetails.Sum(x => x.Quantity);
			var shipping = CalculateShipping(itemsCount);
			var tax = CalculateTax(subTotal + shipping, postalCode);
			var total = subTotal + shipping + tax;

			return new OrderCostSummary()
			{
				CartSubTotal = subTotal.ToString("C"),
				CartShipping = shipping.ToString("C"),
				CartTax = tax.ToString("C"),
				CartTotal = total.ToString("C")
			};
		}

		public OrderCostSummary CalculateCost(List<CartItem> cartItems)
		{
			var itemsCount = cartItems.Sum(x => x.Count);
			var subTotal = cartItems.Sum(x => x.Count * x.Product.Price);
			var shipping = CalculateShipping(itemsCount);
			var tax = CalculateTax(subTotal + shipping);
			var total = subTotal + shipping + tax;

			return new OrderCostSummary
			{
				CartSubTotal = subTotal.ToString("C"),
				CartShipping = shipping.ToString("C"),
				CartTax = tax.ToString("C"),
				CartTotal = total.ToString("C")
			};
		}

		protected decimal CalculateTax(decimal taxable, string postalCode = "")
		{
			var taxRate = (decimal)0.06;
			if (postalCode.StartsWith("98"))
			{
				taxRate = (decimal)0.075;
			}
			return taxable * taxRate;
		}

		protected decimal CalculateShipping(int itemsCount)
		{
			return itemsCount * (decimal)5.0;
		}
	}
}