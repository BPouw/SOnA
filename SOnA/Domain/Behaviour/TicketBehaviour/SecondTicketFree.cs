using Domain.Model;

namespace Domain.Behaviour.Ticket;

public class SecondTicketFree : TicketBehaviour
{
	// Selects every second item in the list
	// Finds the price of every ticket and sums it
	public decimal returnPrice(List<MovieTicket> movieTickets)
	{
		List<MovieTicket> paidTickets = movieTickets.Where((elem, idx) => idx % 2 == 0).ToList();

		return paidTickets.Select(m => m.Price()).Sum();
	}
}