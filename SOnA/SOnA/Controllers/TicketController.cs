using Microsoft.AspNetCore.Mvc;
using Domain;

namespace SOnA.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController : ControllerBase
{
	[HttpGet(Name = "GetTickets")]
	public IEnumerable<MovieTicket> Get ()
	{
		return new List<MovieTicket> { new MovieTicket() };
	}
}