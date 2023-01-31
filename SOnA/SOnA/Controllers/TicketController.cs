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
}