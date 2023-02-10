using System;
namespace Domain
{
	public interface PriceBehaviour
	{
		public decimal returnPrice(decimal originalPrice);
	}
}

