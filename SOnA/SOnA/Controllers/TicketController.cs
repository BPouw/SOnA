using Microsoft.AspNetCore.Mvc;
using Domain;

namespace SOnA.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController : ControllerBase
{
	[HttpGet("/tickets")]
	public IEnumerable<MovieTicket> GetAll ()
	{
		return new []
		{
			new MovieTicket(1, 1, false, null),
			new MovieTicket(1, 1, false, null)
		};
	}

	[HttpPost("/export")]
	public void TriggerExport (TicketExportFormat format)
	{
		MovieTicket ticket = new MovieTicket (1, 1, false, new MovieScreening(new DateTime(), 10, new Movie("James Bond")));
		Order order = new Order(1, false, new List<MovieTicket> () { ticket });

		order.Export(TicketExportFormat.JSON);
	}
}