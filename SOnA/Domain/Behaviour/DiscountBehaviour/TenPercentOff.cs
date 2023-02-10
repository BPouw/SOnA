namespace Domain.Behaviour.Discount;

public class TenPercentOff : DiscountBehaviour
{
	// Takse 10% of the price as a discount
	public decimal returnDiscount()
	{
        return (decimal)0.9;
    }
}