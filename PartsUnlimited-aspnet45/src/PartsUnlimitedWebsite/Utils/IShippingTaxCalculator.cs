using System.Collections.Generic;
using PartsUnlimited.Models;

namespace PartsUnlimited.Utils
{
	public interface IShippingTaxCalculator
	{
		OrderCostSummary CalculateCost(List<CartItem> cartItems);

		OrderCostSummary CalculateCost(List<OrderDetail> orderDetails, string orderZip);
	}
}