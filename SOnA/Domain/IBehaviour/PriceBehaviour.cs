
using Domain.Model;

namespace Domain
{
	public interface PriceBehaviour
	{
		public decimal returnPremium(List<MovieTicket> movieTickets);
	}
}

