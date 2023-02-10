using Domain.Model;

namespace Domain.Behaviour.Ticket;

public class SecondTicketFree : TicketBehaviour
{
	public decimal returnPrice(List<MovieTicket> movieTickets)
	{
		decimal sum = 0;
        bool free = false;

        foreach(MovieTicket m in movieTickets)
        {
            if (!free)
            {
                sum += (decimal)m.Price();
            }

            free = !free;
        }

        return sum;
	}
}