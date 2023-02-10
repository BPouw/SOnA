using System;
namespace Domain
{
	public interface TicketBehaviour
	{
		public decimal returnPrice(List<MovieTicket> movieTickets);
	}
}

