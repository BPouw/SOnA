using Domain.Model;

namespace Domain.Behaviour.Ticket;

public class FullPrice : TicketBehaviour
{
	// Finds the price of the tickets and then sums it
	public decimal returnPrice(List<MovieTicket> movieTickets)
	{
		return movieTickets.Select(m => m.Price()).Sum();
	}
}