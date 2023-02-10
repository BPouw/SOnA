using System;
namespace Domain
{
	public interface DiscountBehaviour
	{
		public decimal returnPrice(decimal originalPrice);
	}
}

