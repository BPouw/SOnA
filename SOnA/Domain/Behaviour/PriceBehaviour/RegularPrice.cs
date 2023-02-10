using Domain.Model;

namespace Domain.Behaviour.Price;

public class RegularPrice : PriceBehaviour
{
	// Finds which tickets have a premium and extracts that then
	// sums al the premiums to return the total to be paid in 
	// premium for the order
	public decimal returnPremium(List<MovieTicket> movieTickets)
	{
		return movieTickets.Where(m => m.isPremium).Count() * 3;
	}
}