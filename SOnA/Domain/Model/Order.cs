using System.Text.Json;
using System.Text.Json.Serialization;
using Domain.State;

namespace Domain.Model;

public class Order
{
	public int orderNr { get; private set; }
	public List<MovieTicket> movieTickets { get; private set; }

	public DiscountBehaviour discountBehaviour {get; private set;}

	public PriceBehaviour priceBehaviour {get; private set;}

	public TicketBehaviour ticketBehaviour {get; private set;}

	public OrderState orderState {get; set;}

	private static readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

	public Order(int orderNr, List<MovieTicket> movieTickets, TicketBehaviour ticketBehaviour, PriceBehaviour priceBehaviour, DiscountBehaviour discountBehaviour)
	{
		this.orderNr = orderNr;
		this.movieTickets = movieTickets;
		this.ticketBehaviour = ticketBehaviour;
		this.priceBehaviour = priceBehaviour;
		this.discountBehaviour = discountBehaviour;
	}

	public decimal CalculatePrice()
	{
		decimal price = this.ticketBehaviour.returnPrice(movieTickets);
		price += this.priceBehaviour.returnPremium(movieTickets);
		price *= this.discountBehaviour.returnDiscount();
		return price;
	}

	public void Export(TicketExportFormat exportFormat)
	{
		switch (exportFormat)
		{
			case (TicketExportFormat.PLAINTEXT):
				string[] ticketString = movieTickets.Select(obj => obj.ToString()).ToArray();
				File.WriteAllLines($"./file/plaintext/{this.orderNr}.txt", ticketString);
				break;

			case (TicketExportFormat.JSON):
				var jsonString = JsonSerializer.Serialize(movieTickets, _options);
				File.WriteAllText($"./file/json/{this.orderNr}.json", jsonString);
				break;
		}
	}
}
