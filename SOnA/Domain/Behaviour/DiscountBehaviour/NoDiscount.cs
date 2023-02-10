namespace Domain.Behaviour.Discount;
public class NoDiscount : DiscountBehaviour
{
	// Returns the original price as there is no discount
	public decimal returnDiscount()
	{
		return 1;
	}
}